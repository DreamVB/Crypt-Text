using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DreamVB.txtCrpyt;
using DreamVB.Tools;
using DreamVB.RndPassword;

namespace txtCrpyt
{
    public partial class frmmain : Form
    {
        private TextCrypt Text_Crypt;

        private const string EncodedFiles = "Encoded Files(*.enc)|*.enc";
        private const string TextFilesExt = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";


        private int SelectedTextBox { get; set; }

        public frmmain()
        {
            InitializeComponent();
        }

        private string OpenTextFile(string Filename)
        {
            string lzBuffer = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(Filename))
                {
                    lzBuffer = sr.ReadToEnd();
                    sr.Close();
                }
                return lzBuffer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveTextFile(string Filename, string buffer)
        {
            string lzBuffer = string.Empty;
            try
            {
                using (StreamWriter sw = new StreamWriter(Filename))
                {
                    sw.Write(buffer);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetOpenDlgFilename(string lFilter = TextFilesExt)
        {
            OpenFileDialog od = new OpenFileDialog();
            string lzFile = string.Empty;

            od.Title = "Open";
            od.Filter = lFilter;

            if (od.ShowDialog().Equals(DialogResult.OK))
            {
                lzFile = od.FileName;
            }

            od.Dispose();
            return lzFile;
        }

        private string GetSaveDlgFilename(string lFilter = TextFilesExt)
        {
            SaveFileDialog sd = new SaveFileDialog();
            string lzFile = string.Empty;

            sd.Title = "Save As";
            sd.Filter = lFilter;
            sd.FilterIndex = 1;

            if (sd.ShowDialog().Equals(DialogResult.OK))
            {
                lzFile = sd.FileName;
            }

            sd.Dispose();
            return lzFile;
        }

        private void cmdOpenPlain_Click(object sender, EventArgs e)
        {
            string lzFile = string.Empty;

            try
            {
                //Show open dialog.
                lzFile = GetOpenDlgFilename();

                if (lzFile.Length == 0)
                {
                    return;
                }
                //Set text in the text box.
                txtPlainText.Text = OpenTextFile(lzFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdOpenCrypted_Click(object sender, EventArgs e)
        {
            string lzFile = string.Empty;

            try
            {
                //Show open dialog.
                lzFile = GetOpenDlgFilename(EncodedFiles);

                if (lzFile.Length == 0)
                {
                    return;
                }
                //Set text in the text box.
                txtEncrypted.Text = OpenTextFile(lzFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdSaveOriginal_Click(object sender, EventArgs e)
        {
            string lzFile = string.Empty;

            try
            {
                //Show save dialog.
                lzFile = GetSaveDlgFilename();

                if (lzFile.Length == 0)
                {
                    return;
                }
                //Save text to filename
                SaveTextFile(lzFile, txtPlainText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdSaveEncrypted_Click(object sender, EventArgs e)
        {
            string lzFile = string.Empty;

            try
            {
                //Show save dialog.
                lzFile = GetSaveDlgFilename(EncodedFiles);

                if (lzFile.Length == 0)
                {
                    return;
                }
                //Save text to filename
                SaveTextFile(lzFile, txtEncrypted.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEncrypted_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedTextBox = 1;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();

                switch (SelectedTextBox)
                {
                    case 0:
                        Clipboard.SetText(txtPlainText.SelectedText, TextDataFormat.Text);
                        txtPlainText.Focus();
                        break;
                    case 1:
                        Clipboard.SetText(txtEncrypted.SelectedText, TextDataFormat.Text);
                        txtEncrypted.Focus();
                        break;
                }
            }
            catch
            {

            }
        }

        private void txtPlainText_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedTextBox = 0;
        }

        private void cmdPaste_Click(object sender, EventArgs e)
        {
            try
            {
                switch (SelectedTextBox)
                {
                    case 0:
                        txtPlainText.SelectedText = Clipboard.GetText();
                        txtPlainText.Focus();
                        break;
                    case 1:
                        txtEncrypted.SelectedText = Clipboard.GetText();
                        txtEncrypted.Focus();
                        break;
                }
            }
            catch
            {

            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crypt Text using TripleDES\nVersion 1.0\n\tThe free text encryption You can trust.\n\tBy Ben a.k.a DreamVB",
                "About - " + Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEncode_Click(object sender, EventArgs e)
        {
            frmpassword frm = new frmpassword();
            tools.ButtonPress = 0;
            //Show password dialog.
            frm.ShowDialog();
            if (tools.ButtonPress == 1)
            {
                try
                {
                    //Encrypt
                    Text_Crypt = new TextCrypt(tools.Password);
                    //Set output text
                    txtEncrypted.Text=Text_Crypt.Encrypt(txtPlainText.Text);
                    if (mnuCopyOp1.Checked)
                    {
                        try
                        {
                            Clipboard.Clear();
                            Clipboard.SetText(txtEncrypted.Text, TextDataFormat.Text);
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmdDecode_Click(object sender, EventArgs e)
        {
            frmpassword frm = new frmpassword();
            tools.ButtonPress = 0;
            //Show password dialog.
            frm.ShowDialog();
            if (tools.ButtonPress == 1)
            {
                try
                {
                    //Decrypt
                    Text_Crypt = new TextCrypt(tools.Password);
                    //Set output text
                    txtPlainText.Text = Text_Crypt.Decrypt(txtEncrypted.Text);
                    //Copy plain text to clipboard.
                    if (mnuCopyOp2.Checked)
                    {
                        try
                        {
                            Clipboard.Clear();
                            Clipboard.SetText(txtPlainText.Text, TextDataFormat.Text);
                        }
                        catch
                        {

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("The password entered was incorrect.",
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            mnuAbout.Text = "&About -- " + Text;
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            switch (SelectedTextBox)
            {
                case 0:
                    txtPlainText.Clear();
                    txtPlainText.Focus();
                    break;
                case 1:
                    txtEncrypted.Clear();
                    txtEncrypted.Focus();
                    break;
            }
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            switch (SelectedTextBox)
            {
                case 0:
                    txtPlainText.SelectAll();
                    txtPlainText.Focus();
                    break;
                case 1:
                    txtEncrypted.SelectAll();
                    txtEncrypted.Focus();
                    break;
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            cmdCopy_Click(sender, e);
        }

        private void mnuPasue_Click(object sender, EventArgs e)
        {
            cmdPaste_Click(sender, e);
        }

        private void mnuReadme_Click(object sender, EventArgs e)
        {
            string lzFile = tools.FixPath(Environment.CurrentDirectory) + "Readme.txt";
            //Load readme file.
            if (File.Exists(lzFile))
            {
                tools.WinExe(lzFile);
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            cmdAbout_Click(sender, e);
        }

        private void mnuOpenPlain_Click(object sender, EventArgs e)
        {
            cmdOpenPlain_Click(sender, e);
        }

        private void mnuOpenEncoded_Click(object sender, EventArgs e)
        {
            cmdOpenCrypted_Click(sender, e);
        }

        private void mnuSavePlain_Click(object sender, EventArgs e)
        {
            cmdSaveOriginal_Click(sender, e);
        }

        private void mnuSaveEncoded_Click(object sender, EventArgs e)
        {
            cmdSaveEncrypted_Click(sender, e);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            cmdClose_Click(sender, e);
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            switch (SelectedTextBox)
            {
                case 0:
                    txtPlainText.Undo();
                    txtPlainText.Focus();
                    break;
                case 1:
                    txtEncrypted.Undo();
                    txtEncrypted.Focus();
                    break;
            }
        }

        private void cmdSendEmail_Click(object sender, EventArgs e)
        {
            tools.WinExe("mailto:?body=" + txtEncrypted.Text);
        }

        private void mnuSendemail_Click(object sender, EventArgs e)
        {
            cmdSendEmail_Click(sender, e);
        }

        private void txtPlainText_Leave(object sender, EventArgs e)
        {
            txtPlainText.BackColor = Color.White;
        }

        private void txtPlainText_Enter(object sender, EventArgs e)
        {
            txtPlainText.BackColor = Color.AliceBlue;
        }

        private void txtEncrypted_Leave(object sender, EventArgs e)
        {
            txtEncrypted.BackColor = Color.White;
        }

        private void txtEncrypted_Enter(object sender, EventArgs e)
        {
            txtEncrypted.BackColor = Color.AliceBlue;
        }

        private void mnuCopyOp1_Click(object sender, EventArgs e)
        {
            mnuCopyOp1.Checked = !mnuCopyOp1.Checked;
        }

        private void mnuCopyOp2_Click(object sender, EventArgs e)
        {
            mnuCopyOp2.Checked = !mnuCopyOp2.Checked;
        }

        private void mnuPwsGen_Click(object sender, EventArgs e)
        {
            frmPwsGen frm = new frmPwsGen();
            frm.ShowDialog();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
