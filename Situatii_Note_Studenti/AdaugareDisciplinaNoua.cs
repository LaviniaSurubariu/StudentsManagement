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
    public partial class AdaugareDisciplinaNoua : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dataReader;
        public AdaugareDisciplinaNoua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbNumeDisciplina.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbNumeDisciplina, "Introduceti numele");
            }
            else if (tbCredite.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbCredite, "Introduceti numarul de credite");
            }

            else if (tbAn.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbAn, "Introduceti anul");
            }
            else
            {


                try
                {
                    conexiune.Open();
                    cmd = new SqlCommand("INSERT INTO Discipline( nume_disciplina, nr_credite, an) VALUES ( @nume_disciplina, @nr_credite, @an)", conexiune);
                    cmd.Parameters.AddWithValue("@nume_disciplina", tbNumeDisciplina.Text);
                    cmd.Parameters.AddWithValue("@nr_credite", Convert.ToInt32(tbCredite.Text));
                    cmd.Parameters.AddWithValue("@an", Convert.ToInt32(tbAn.Text));
                    cmd.ExecuteNonQuery();
                    //conexiune.Close();
                    MessageBox.Show("Disciplina inserata cu succes");
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

       

        private void tbCredite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AdaugareDisciplinaNoua_Load(object sender, EventArgs e)
        {

        }
    }
}
