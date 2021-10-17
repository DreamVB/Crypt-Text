using System;
using System.Windows.Forms;
using DreamVB.RndPassword;

namespace txtCrpyt
{
    public partial class frmPwsGen : Form
    {
        public frmPwsGen()
        {
            InitializeComponent();
        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            //Create random password class.
            RandomPassword rp = new RandomPassword();

            //Set class properties
            rp.Uppercase = chkUpper.Checked;
            rp.Lowercase = chkLower.Checked;
            rp.Numbers =chkNumbers.Checked;
            rp.Special = chkSpecial.Checked;
            rp.Length = (int)txtLength.Value;
            //Update text box.
            txtPws.Text = rp.Generate();
            txtPws.SelectAll();
            txtPws.Focus();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
