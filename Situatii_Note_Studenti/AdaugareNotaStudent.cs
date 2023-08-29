using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//situatii note studenti
//studenti, discipline, centralizator

namespace Situatii_Note_Studenti
{

    public partial class AdaugareNotaStudent : Form
    {


        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dataReader;




        //Student s;
        //Disciplina d;
        //private List<Student> listaStudenti = new List<Student>();
        //private List<Disciplina> listaDiscipline = new List<Disciplina>();


        //cateva testari
        public AdaugareNotaStudent()
        {
            //float[] note = { 3, 4, 5 };
            //float[] note2 = { 4, 5, 6 };
            //Disciplina disciplina = new Disciplina("Matemtica", 4, note);
            //Disciplina disciplina2 = new Disciplina("Romana", 6, note2);
            //disciplina += 10;


            //MessageBox.Show(Convert.ToString(disciplina.AverageNote()));

            //List<Disciplina> listaDis = new List<Disciplina>
            //{
            //    disciplina,disciplina2
            //};
            //Disciplina clona = disciplina.Clone();
            ////MessageBox.Show(clona.ToString());



            //Student s = new Student("Vasile", "Vasile", 2, 1060, listaDis);
            //// MessageBox.Show(s.ToString());
            ////s++;
            //Student clona1 = s.Clone();
            //foreach (Disciplina disciplina1 in listaDis)
            //{
            //    disciplina1.Note[0] = 10;
            //}
            ////MessageBox.Show(clona1.ToString());
            //foreach (Disciplina dis in s)
            //{
            //    //MessageBox.Show(dis.ToString());
            //}
            ////MessageBox.Show(s.ToString());
            //// MessageBox.Show(clona1.ToString());

            //// MessageBox.Show(Convert.ToString(s.AverageNote()));
            //// MessageBox.Show( s.CompareTo(clona1).ToString());
            ///



            //DataTable dt = new DataTable();
            //adapter = new SqlDataAdapter("SELECT MAX(Id_Student)+1 FROM Studenti", conexiune);
            //adapter.Fill(dt);
            //tbIdStudent.Text = cmd.ExecuteScalar().ToString();

            InitializeComponent();
        }




        //inserarea notelor
        private void btnAdaugareStudent_Click(object sender, EventArgs e)
        {
            if (cbIdStudent.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbIdStudent, "Selectati studentul");
            }
            else
                if (cbMaterie.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbMaterie, "Selectati materia");
            }
            else if (tbNota.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbNota, "Introduceti nota");
            }
            else
            {


                try
                {

                    string idMaterie = "";
                    string numeMaterie = "";
                    string nrCredite = "";
                    string an = "";

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Discipline WHERE nume_disciplina=@nume_disciplina", conexiune);
                    conexiune.Open();
                    cmd2.Parameters.AddWithValue("@nume_disciplina", cbMaterie.Text);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        idMaterie = reader["Id_disciplina"].ToString();
                        numeMaterie = reader["nume_disciplina"].ToString();
                        nrCredite = reader["nr_credite"].ToString();
                        an = reader["an"].ToString();

                    }
                    conexiune.Close();

                    conexiune.Open();



                    cmd = new SqlCommand("INSERT INTO Detalii_Studenti(id_stud, id_disc, nota) VALUES (@id_stud, @id_disc, @nota)", conexiune);
                    cmd.Parameters.AddWithValue("@id_stud", cbIdStudent.Text);
                    cmd.Parameters.AddWithValue("@id_disc", idMaterie);
                    cmd.Parameters.AddWithValue("@nota", Convert.ToInt32(tbNota.Text));
                    cmd.ExecuteNonQuery();




                    cmd2.ExecuteNonQuery();
                    conexiune.Close();

                    MessageBox.Show("Nota inserata cu succes.", "Inserare Executata");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conexiune.Close(); }
            }
        }



        //selectez tot din discipline si studenti si pun in combobox
        private void AdaugareStudent_Load_1(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("SELECT * FROM Discipline ", conexiune);
                conexiune.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbMaterie.Items.Add(dataReader["nume_disciplina"]);

                }
                conexiune.Close();


                cmd = new SqlCommand("SELECT * FROM Studenti", conexiune);
                conexiune.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbIdStudent.Items.Add(dataReader["Id_Student"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }


        }

        //autocompletez datele pentru materii
        private void cbMaterie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Discipline WHERE nume_disciplina=@nume_disciplina", conexiune);
                cmd.Parameters.AddWithValue("@nume_disciplina", cbMaterie.Text);
                conexiune.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    string credite = dataReader["nr_credite"].ToString();
                    tbCredite.Text = credite;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }


        //autocompletez datele pentru studenti
        private void cbIdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Studenti WHERE Id_Student=@Id_Student", conexiune);
                cmd.Parameters.AddWithValue("@Id_Student", cbIdStudent.Text);
                conexiune.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string nume = dataReader["Nume"].ToString();
                    string prenume = dataReader["Prenume"].ToString();
                    string an = dataReader["An"].ToString();
                    string Grupa = dataReader["Grupa"].ToString();

                    tbNume.Text = nume;
                    tbPrenume.Text = prenume;
                    tbAn.Text = an;
                    tbGrupa.Text = Grupa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }


        }

        private void tbNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }
    }
}
