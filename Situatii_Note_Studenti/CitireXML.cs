using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Situatii_Note_Studenti
{
    public partial class CitireXML : Form
    {
        public CitireXML()
        {
            InitializeComponent();
        }

        private void btnInsereazaDinXML_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "studenti.xml";
                DataTable dataTable = LoadXmlData(filePath);
                dgvlistStudXML.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public static DataTable LoadXmlData(string filePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id_Student", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataTable.Columns.Add("Prenume", typeof(string));
            dataTable.Columns.Add("An", typeof(int));
            dataTable.Columns.Add("Grupa", typeof(int));

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList studentNodes = xmlDoc.SelectNodes("//Student");

            foreach (XmlNode studentNode in studentNodes)
            {
                int idStudent = int.Parse(studentNode.SelectSingleNode("Id_Student")?.InnerText);
                string nume = studentNode.SelectSingleNode("Nume")?.InnerText;
                string prenume = studentNode.SelectSingleNode("Prenume")?.InnerText;
                int an = int.Parse(studentNode.SelectSingleNode("An")?.InnerText);
                int grupa = int.Parse(studentNode.SelectSingleNode("Grupa")?.InnerText);

                dataTable.Rows.Add(idStudent, nume, prenume, an, grupa);
            }

            return dataTable;
        }

        private void CitireXML_Load(object sender, EventArgs e)
        {

        }
    }
}
