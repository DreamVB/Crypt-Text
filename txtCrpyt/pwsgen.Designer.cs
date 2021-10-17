namespace txtCrpyt
{
    partial class frmPwsGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gOptions = new System.Windows.Forms.GroupBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.lblPwsLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.NumericUpDown();
            this.cmdGen = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblPws = new System.Windows.Forms.Label();
            this.txtPws = new System.Windows.Forms.TextBox();
            this.gOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.SuspendLayout();
            // 
            // gOptions
            // 
            this.gOptions.Controls.Add(this.chkSpecial);
            this.gOptions.Controls.Add(this.chkNumbers);
            this.gOptions.Controls.Add(this.chkLower);
            this.gOptions.Controls.Add(this.chkUpper);
            this.gOptions.Controls.Add(this.lblPwsLength);
            this.gOptions.Controls.Add(this.txtLength);
            this.gOptions.Location = new System.Drawing.Point(12, 12);
            this.gOptions.Name = "gOptions";
            this.gOptions.Size = new System.Drawing.Size(190, 164);
            this.gOptions.TabIndex = 0;
            this.gOptions.TabStop = false;
            this.gOptions.Text = "Password options";
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(22, 28);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(91, 17);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "UPPERCASE";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(22, 51);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(74, 17);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "lowercase";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(22, 74);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(68, 17);
            this.chkNumbers.TabIndex = 2;
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(22, 97);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(61, 17);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // lblPwsLength
            // 
            this.lblPwsLength.AutoSize = true;
            this.lblPwsLength.Location = new System.Drawing.Point(19, 127);
            this.lblPwsLength.Name = "lblPwsLength";
            this.lblPwsLength.Size = new System.Drawing.Size(43, 13);
            this.lblPwsLength.TabIndex = 1;
            this.lblPwsLength.Text = "Length:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(68, 123);
            this.txtLength.Maximum = new decimal(new int[] {
            390,
            0,
            0,
            0});
            this.txtLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(54, 20);
            this.txtLength.TabIndex = 2;
            this.txtLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cmdGen
            // 
            this.cmdGen.Location = new System.Drawing.Point(208, 22);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(126, 35);
            this.cmdGen.TabIndex = 3;
            this.cmdGen.Text = "Generate";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(208, 63);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(126, 35);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblPws
            // 
            this.lblPws.AutoSize = true;
            this.lblPws.Location = new System.Drawing.Point(123, 185);
            this.lblPws.Name = "lblPws";
            this.lblPws.Size = new System.Drawing.Size(108, 13);
            this.lblPws.TabIndex = 5;
            this.lblPws.Text = "Generated password:";
            // 
            // txtPws
            // 
            this.txtPws.BackColor = System.Drawing.Color.White;
            this.txtPws.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPws.Location = new System.Drawing.Point(61, 211);
            this.txtPws.Name = "txtPws";
            this.txtPws.ReadOnly = true;
            this.txtPws.Size = new System.Drawing.Size(238, 22);
            this.txtPws.TabIndex = 6;
            // 
            // frmPwsGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 248);
            this.Controls.Add(this.txtPws);
            this.Controls.Add(this.lblPws);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGen);
            this.Controls.Add(this.gOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPwsGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Generator";
            this.gOptions.ResumeLayout(false);
            this.gOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gOptions;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.Label lblPwsLength;
        private System.Windows.Forms.NumericUpDown txtLength;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label lblPws;
        private System.Windows.Forms.TextBox txtPws;
    }
}