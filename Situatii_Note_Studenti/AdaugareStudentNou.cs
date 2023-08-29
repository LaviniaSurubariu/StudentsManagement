using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situatii_Note_Studenti
{
    public partial class AdaugareStudentNou : Form
    {

        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dataReader;
        public AdaugareStudentNou()
        {
            InitializeComponent();
        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
            if (tbNumeStudent.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbNumeStudent, "Introduceti numele");
            }
            else
            if (tbPrenumeStudent.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbPrenumeStudent, "Introduceti prenumele");
            }
            else
            if (tbAn.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbAn, "Introduceti anul");
            }
            else
            if (tbGrupa.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbGrupa, "Introduceti grupa");
            }
            else

            {


                try
                {
                    conexiune.Open();
                    cmd = new SqlCommand("INSERT INTO Studenti( Nume, Prenume, An, Grupa) VALUES ( @Nume, @Prenume, @An, @Grupa)", conexiune);
                    cmd.Parameters.AddWithValue("@Nume", tbNumeStudent.Text);
                    cmd.Parameters.AddWithValue("@Prenume", tbPrenumeStudent.Text);
                    cmd.Parameters.AddWithValue("@An", Convert.ToInt32(tbAn.Text));
                    cmd.Parameters.AddWithValue("@Grupa", Convert.ToInt32(tbGrupa.Text));
                    cmd.ExecuteNonQuery();
                    //conexiune.Close();
                    MessageBox.Show("Student inserat cu succes");
                    this.Close();
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

        private void AdaugareStudentNou_Load(object sender, EventArgs e)
        {

        }

        private void tbAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbGrupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AdaugareStudentNou_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {


                if (e.Button == MouseButtons.Right)
                {
                    // Obțin datele din textbox-uri
                    string nume = tbNumeStudent.Text;
                    string prenume = tbPrenumeStudent.Text;
                    int an = Convert.ToInt32(tbAn.Text);
                    int grupa = Convert.ToInt32(tbGrupa.Text);

                    // Generez conținutul pentru fișierul text
                    string continut = "Nume: " + nume + Environment.NewLine;
                    continut += "Prenume: " + prenume + Environment.NewLine;
                    continut += "An: " + an.ToString() + Environment.NewLine;
                    continut += "Grupa: " + grupa.ToString() + Environment.NewLine;

                    string folderCurent = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string caleFisier = Path.Combine(folderCurent, "student.txt");

                    // Creez și scriu în fișierul text
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(caleFisier))
                        {
                            sw.Write(continut);
                        }
                        MessageBox.Show("Fișierul a fost generat cu succes.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare la generarea fișierului: " + ex.Message);
                    }
                }
            }
           catch (Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
