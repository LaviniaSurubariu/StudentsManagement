using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situatii_Note_Studenti
{
    public partial class DataSiOra : UserControl
    {
        public DataSiOra()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            label2.Visible = true;
            pictureBox1.Visible = true;
        }

        private void DataSiOra_Load(object sender, EventArgs e)
        {

        }
    }
}
