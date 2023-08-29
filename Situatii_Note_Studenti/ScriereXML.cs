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
    public partial class ScriereXML : Form
    {

        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SituatiiNoteStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        public ScriereXML()
        {
            InitializeComponent();
        }

        private void ScriereXML_Load(object sender, EventArgs e)
        {
            try
            {


                conexiune.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Studenti", conexiune);
                adapter.Fill(dt);
                dgvlistStudXML.DataSource = dt;
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

        private void btnGenereazaXML_Click(object sender, EventArgs e)
        {

            try
            {
                conexiune.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Studenti", conexiune);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataSet dataSet = new DataSet("StudentiData");
                    DataTable dataTable = new DataTable("Student");
                    dataSet.Tables.Add(dataTable);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn column = new DataColumn(reader.GetName(i), reader.GetFieldType(i));
                        dataTable.Columns.Add(column);
                    }

                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader.GetValue(i);
                        }
                        dataTable.Rows.Add(row);
                    }

                    string filePath = "studenti.xml";
                    dataSet.WriteXml(filePath, XmlWriteMode.WriteSchema);
                    MessageBox.Show("Datele au fost salvate în fișierul XML.");
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


    }
}

