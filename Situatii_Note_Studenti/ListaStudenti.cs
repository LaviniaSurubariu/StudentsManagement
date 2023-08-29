using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situatii_Note_Studenti
{
    public partial class ListaStudenti : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    SqlDataAdapter adapter;
        //    SqlCommand command;


        public ListaStudenti()
        {
            InitializeComponent();
        }

        private void ListaStudenti_Load(object sender, EventArgs e)
        {
            try
            {


                conexiune.Open();

                SqlCommand command = new SqlCommand("SELECT  Grupa FROM Studenti group by Grupa ORDER BY Grupa ASC", conexiune);
                SqlDataReader reader = command.ExecuteReader();
                TreeNode groupNode = new TreeNode();

                List<string> grupe = new List<string>();
                while (reader.Read())
                {
                    string grupa = reader["Grupa"].ToString();
                    grupe.Add(grupa);
                    groupNode = new TreeNode(reader["Grupa"].ToString());
                    treeView1.Nodes.Add(groupNode);
                }
                grupe.Select(item => item.ToString()).Distinct();
                reader.Close();



               // command = new SqlCommand("SELECT distinct * FROM Studenti ",conexiune);

               //SqlDataReader reader2 = command.ExecuteReader();

               // List<Student> liststud = new List<Student>();

               // while (reader2.Read())
               // {
               //     Student student = new Student();

               //     student.Id =Convert.ToInt32(reader2["Id_student"]);
               //     student.Nume = reader2["Nume"].ToString();
               //     student.Prenume = reader2["Prenume"].ToString();
               //     student.An = Convert.ToInt32(reader2["An"]);
               //     student.Grupa = Convert.ToInt32(reader2["Grupa"]);
               //     //student.Discipline = new List<Disciplina>();
                   
               //     liststud.Add(student);



               // }
               // reader2.Close();


               

                // command = new SqlCommand("SELECT id_stud,id_disc,nota FROM Detalii_Studenti",conexiune);
                //reader = command.ExecuteReader();
                //List<Disciplina> listdisc = new List<Disciplina>();

                //while (reader.Read())
                //{
                //    int IdStud = Convert.ToInt32(reader["id_stud"]);
                //    int IdDisciplina= Convert.ToInt32(reader["id_disc"]);
                //   float nota= (float)Convert.ToInt32(reader["nota"]);
                    

                //    foreach (Student stud in liststud)
                //    {

                //        if (stud.Id == IdStud)
                //        {

                //            Disciplina disciplina = new Disciplina();
                //            disciplina.Id = IdDisciplina;
                //            float[]note= new float[1];
                //            note[0] = nota;
                //            disciplina.Note = note;
                //            listdisc.Add(disciplina);
                //            //MessageBox.Show(disciplina.ToString());

                //        }
                //        stud.Discipline = listdisc;
                //    }

                
                //}
                //reader.Close();



                command = new SqlCommand("SELECT  Id_Student,Nume,Prenume, Grupa FROM Studenti ORDER BY Nume ASC", conexiune);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    foreach (TreeNode treeNode in treeView1.Nodes)
                    {
                        if (treeNode.Text == reader["Grupa"].ToString())
                        {
                            string nume = reader["Nume"].ToString().Trim();
                            string prenume = reader["Prenume"].ToString().Trim();
                            int id_stud =Convert.ToInt32( reader["Id_Student"]);

                            treeNode.Nodes.Add(nume +" "+ prenume);



                            //foreach(Student stud in liststud)
                            //{
                            //    if (stud.Id == id_stud)
                            //    {
                            //        foreach(Disciplina disciplina in stud.Discipline)
                            //        {
                            //            treeNode.Nodes.Add(disciplina.Nume.ToString()).Nodes.Add(disciplina.Note.ToString());

                            //        }

                            //    }
                            //}
                           


                        }

                    }
                }


                reader.Close();

               // treeView1.ExpandAll();
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

        
    }

}
