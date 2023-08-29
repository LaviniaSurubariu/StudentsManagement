using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situatii_Note_Studenti
{

    public partial class GraficNote : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        SqlCommand command;

       

        public GraficNote()
        {
            InitializeComponent();
        }

        private void GraficNote_Load(object sender, EventArgs e)
        {

            try
            {

                conexiune.Open();
                SqlCommand command = new SqlCommand("SELECT DISTINCT Grupa FROM Studenti ORDER BY Grupa ASC", conexiune);
                SqlDataReader reader = command.ExecuteReader();
                List<string> grupe = new List<string>();
                double[] medii = new double[4];
                
                while (reader.Read())
                {
                    string grupa = reader["Grupa"].ToString();
                    grupe.Add(grupa);
                   
                }

                reader.Close();


                for (int i = 0; i < grupe.Count; i++)
                {
                    command = new SqlCommand("SELECT AVG(nota) FROM Detalii_Studenti WHERE id_stud IN (SELECT Id_Student FROM Studenti WHERE Grupa=@Grupa)", conexiune);
                    command.Parameters.AddWithValue("@Grupa", grupe[i]);
                    try
                    {
                        medii[i] = Convert.ToDouble(command.ExecuteScalar());

                    }catch (Exception ex)
                    {
                        medii[i] = 0;
                    }


                }

                for (int j = 0; j < medii.Length; j++)
                {
                   
                    chart1.Series["Medie"].Points.AddXY("Grupa " + grupe[j], medii[j]);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
            finally { conexiune.Close(); 
            }




            panel1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Opening += ContextMenuStrip1_Opening;
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip contextMenu = sender as ContextMenuStrip;
            contextMenu.Items.Clear();

            ToolStripMenuItem previewItem = new ToolStripMenuItem("Previzualizare");
            ToolStripMenuItem printItem = new ToolStripMenuItem("Imprimare");

            previewItem.Click += PreviewItem_Click;
            printItem.Click += PrintItem_Click;

            contextMenu.Items.Add(previewItem);
            contextMenu.Items.Add(printItem);
        }

        private void PreviewItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Bitmap chartImage = new Bitmap(panel1.Width, panel1.Height))
            {
                panel1.DrawToBitmap(chartImage, panel1.ClientRectangle);
                g.DrawImage(chartImage, new Point(100, 100));
            }

            e.HasMorePages = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
