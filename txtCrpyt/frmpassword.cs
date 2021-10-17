using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamVB.Tools;

namespace txtCrpyt
{
    public partial class frmpassword : Form
    {
        public frmpassword()
        {
            InitializeComponent();
        }

        private void txtPws_TextChanged(object sender, EventArgs e)
        {
            cmdOK.Enabled = (txtPws.Text.Trim().Length > 0);
        }

        private void frmpassword_Load(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            if (txtPws.Text.Trim().Length < 4)
            {
                MessageBox.Show("The password is to short.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Set focus on password box.
                txtPws.Focus();
                return;
            }

            tools.ButtonPress = 1;
            tools.Password = txtPws.Text;
            Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            tools.ButtonPress = 0;
            Close();
        }

        private void txtPws_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                if (cmdOK.Enabled)
                {
                    cmdOK_Click(sender, e);
                }
            }
        }
    }
}
