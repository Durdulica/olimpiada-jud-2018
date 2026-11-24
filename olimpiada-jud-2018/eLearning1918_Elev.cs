using System;
using System.Windows.Forms;

namespace olimpiada_jud_2018
{
    public partial class eLearning1918_Elev : Form
    {
        public eLearning1918_Elev()
        {
            InitializeComponent();
        }

        private void eLearning1918_Elev_Load(object sender, EventArgs e)
        {

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
