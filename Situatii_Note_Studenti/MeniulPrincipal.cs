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
    public partial class MeniulPrincipal : Form
    {
        public MeniulPrincipal()
        {
            InitializeComponent();
        }

        private void MeniulPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void disciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDisciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDiscipline listaDiscipline=new ListaDiscipline();
            listaDiscipline.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void inserareStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareStudentNou adaugareStudentNou= new AdaugareStudentNou();
            adaugareStudentNou.ShowDialog();
        }

        private void inserareNotaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareNotaStudent adaugareNotaStudent = new AdaugareNotaStudent();
            adaugareNotaStudent.ShowDialog();
        }

        private void adaugaDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareDisciplinaNoua adaugareDisciplinaNoua=new AdaugareDisciplinaNoua();
            adaugareDisciplinaNoua.ShowDialog();
        }

        private void listaStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaStudenti listaStudenti = new ListaStudenti();
            listaStudenti.ShowDialog();
        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficNote graficNote = new GraficNote();
            graficNote.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void scriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriereXML scriere = new ScriereXML();
            scriere.ShowDialog();
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitireXML citire = new CitireXML();
            citire.ShowDialog();
        }

        private void listaNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaNote listaNote = new ListaNote();
            listaNote.ShowDialog();
        }
    }
}
