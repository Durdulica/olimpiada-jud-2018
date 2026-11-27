using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace olimpiada_jud_2018
{
    public partial class eLearning1918_start : Form
    {
        List<Utilizator> utilizatori;
        private string[] imagini = Directory.GetFiles(Path.Combine(Application.StartupPath, "..", "..", "Resources"));
        private int indexGalerie = 0;
        public eLearning1918_start()
        {
            InitializeComponent();
            utilizatori = Date.CitesteUtilizatori();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Utilizator u = utilizatori.FirstOrDefault(x => x.EmailUtilizator == txtEmail.Text);
            if(u == null)
            {
                MessageBox.Show("Nu exista un utilizator cu acest email!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if(u.ParolaUtilizator != txtParola.Text)
            {
                MessageBox.Show("Parola gresita!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParola.Focus();
                txtParola.Text = "";
                return;
            }

            eLearning1918_Elev learn = new eLearning1918_Elev(u, utilizatori);
            Hide();
            learn.ShowDialog();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (btnManual.Text == "Manual")
            {
                btnManual.Text = "Automat";
                btnInainte.Enabled = true;
                btnInapoi.Enabled = true;
            }

            else if(btnManual.Text == "Automat")
            {
                btnManual.Text = "Manual";
                btnInainte.Enabled = false;
                btnInapoi.Enabled = false;
            }
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

        private Image Imagine()
        {
            string cale = Path.Combine(Application.StartupPath, "..", "..", "Resources", imagini[indexGalerie]);
            if (!File.Exists(cale)) 
            {
                return null;
            }

            return Image.FromFile(cale);
        }

        private void AfiseazaGalerie()
        {
            
            bool areImagini = imagini.Length > 0;
            btnInapoi.Enabled = areImagini && indexGalerie > 0;
            btnInainte.Enabled = areImagini && indexGalerie < imagini.Length - 1;
            progBar.Maximum = imagini.Length;

            picSlideshow.Image = Imagine();
            progBar.Value = indexGalerie + 1;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            indexGalerie--;
            AfiseazaGalerie();
        }

        private void btnInainte_Click(object sender, EventArgs e)
        {
            indexGalerie++;
            AfiseazaGalerie();
        }
    }
}
