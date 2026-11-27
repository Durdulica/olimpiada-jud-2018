using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace olimpiada_jud_2018
{
    public partial class eLearning1918_Elev : Form
    {
        List<Utilizator> utilizatori;
        Utilizator utilizator;
        public eLearning1918_Elev(Utilizator utilizator, List<Utilizator> utilizatori)
        {
            InitializeComponent();
            this.utilizator = utilizator;
            this.utilizatori = utilizatori;
        }

        private void eLearning1918_Elev_Load(object sender, EventArgs e)
        {
            lblNume.Text += utilizator.NumePrenumeUtilizator;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carnetDeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabElev.SelectedTab = tabCarnetNote;
        }

        private void graficNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabElev.SelectedTab = tabGrafic;
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabElev.SelectedTab = tabTeste;
        }

        private void eLearning1918_Elev_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
