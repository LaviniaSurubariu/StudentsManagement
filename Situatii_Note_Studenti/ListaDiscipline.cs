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
    public partial class ListaDiscipline : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        SqlCommand command;
        public ListaDiscipline()
        {
            InitializeComponent();
        }

        //afisare 
        private void ListaDiscipline_Load(object sender, EventArgs e)
        {
            try
            {
                conexiune.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Discipline", conexiune);
                adapter.Fill(dt);
                dgvListaDiscipline.DataSource = dt;
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

        private void dgvListaDiscipline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
