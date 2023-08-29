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
    public partial class ListaNote : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        public ListaNote()
        {
            InitializeComponent();
        }

        private void ListaNote_Load(object sender, EventArgs e)
        {
            try
            {

               

                conexiune.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Detalii_Studenti", conexiune);
                adapter.Fill(dt);
                dgvListaNote.DataSource = dt;
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

        private void dgvListaNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo dragInfo =dgvListaNote.HitTest(e.X, e.Y);

                if (dragInfo.RowIndex >= 0 && dragInfo.RowIndex < dgvListaNote.Rows.Count)
                {
                    dgvListaNote.DoDragDrop(dgvListaNote.Rows[dragInfo.RowIndex], DragDropEffects.Move);
                }
            }
        }

        private void dgvListaNote_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void dgvListaNote_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvListaNote.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo dropInfo = dgvListaNote.HitTest(clientPoint.X, clientPoint.Y);

            if (dropInfo.RowIndex >= 0 && dropInfo.RowIndex < dgvListaNote.Rows.Count)
            {
                DataGridViewRow draggedRow = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                

                
                int idStud = Convert.ToInt32(draggedRow.Cells[0].Value);
                int idDisc = Convert.ToInt32(draggedRow.Cells[1].Value);
                dgvListaNote.Rows.Remove(draggedRow);
                StergeDinBD(idStud, idDisc);
            }
        }
        private void StergeDinBD(int idStud, int idDisc)
        {
            try
            {
                conexiune.Open();
               
                    string query = "DELETE FROM Detalii_studenti WHERE id_stud = @idStud AND id_disc = @idDisc";
                    SqlCommand command = new SqlCommand(query, conexiune);
                   command.Parameters.AddWithValue("@idStud", idStud);
                    command.Parameters.AddWithValue("@idDisc", idDisc);
                    command.ExecuteNonQuery();
                  
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

        private void dgvListaNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
