using System;
using System.Windows.Forms;

namespace olimpiada_jud_2018
{
    public partial class eLearning1918_start : Form
    {
        public eLearning1918_start()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
    }
}
