namespace lab2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemReset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxSelectUnit = new System.Windows.Forms.GroupBox();
            this.radioButtonTemp = new System.Windows.Forms.RadioButton();
            this.radioButtonMass = new System.Windows.Forms.RadioButton();
            this.radioButtonLength = new System.Windows.Forms.RadioButton();
            this.BoxConvertFrom = new System.Windows.Forms.GroupBox();
            this.textBoxConvertFrom = new System.Windows.Forms.TextBox();
            this.comboBoxConvertFrom = new System.Windows.Forms.ComboBox();
            this.BoxConvertTo = new System.Windows.Forms.GroupBox();
            this.textBoxConvertTo = new System.Windows.Forms.TextBox();
            this.comboBoxConvertTo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.BoxSelectUnit.SuspendLayout();
            this.BoxConvertFrom.SuspendLayout();
            this.BoxConvertTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReset,
            this.menuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemReset
            // 
            this.menuItemReset.Name = "menuItemReset";
            this.menuItemReset.Size = new System.Drawing.Size(47, 20);
            this.menuItemReset.Text = "Reset";
            this.menuItemReset.Click += new System.EventHandler(this.menuItemReset_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(38, 20);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // BoxSelectUnit
            // 
            this.BoxSelectUnit.BackColor = System.Drawing.Color.Silver;
            this.BoxSelectUnit.Controls.Add(this.radioButtonTemp);
            this.BoxSelectUnit.Controls.Add(this.radioButtonMass);
            this.BoxSelectUnit.Controls.Add(this.radioButtonLength);
            this.BoxSelectUnit.Location = new System.Drawing.Point(101, 127);
            this.BoxSelectUnit.Name = "BoxSelectUnit";
            this.BoxSelectUnit.Size = new System.Drawing.Size(200, 163);
            this.BoxSelectUnit.TabIndex = 1;
            this.BoxSelectUnit.TabStop = false;
            this.BoxSelectUnit.Text = "Select Units =>";
            // 
            // radioButtonTemp
            // 
            this.radioButtonTemp.AutoSize = true;
            this.radioButtonTemp.Location = new System.Drawing.Point(22, 129);
            this.radioButtonTemp.Name = "radioButtonTemp";
            this.radioButtonTemp.Size = new System.Drawing.Size(85, 17);
            this.radioButtonTemp.TabIndex = 2;
            this.radioButtonTemp.Text = "Temperature";
            this.radioButtonTemp.UseVisualStyleBackColor = true;
            this.radioButtonTemp.CheckedChanged += new System.EventHandler(this.radioButtonTemp_CheckedChanged);
            // 
            // radioButtonMass
            // 
            this.radioButtonMass.AutoSize = true;
            this.radioButtonMass.Location = new System.Drawing.Point(22, 83);
            this.radioButtonMass.Name = "radioButtonMass";
            this.radioButtonMass.Size = new System.Drawing.Size(50, 17);
            this.radioButtonMass.TabIndex = 1;
            this.radioButtonMass.Text = "Mass";
            this.radioButtonMass.UseVisualStyleBackColor = true;
            this.radioButtonMass.CheckedChanged += new System.EventHandler(this.radioButtonMass_CheckedChanged);
            // 
            // radioButtonLength
            // 
            this.radioButtonLength.AutoSize = true;
            this.radioButtonLength.Location = new System.Drawing.Point(22, 37);
            this.radioButtonLength.Name = "radioButtonLength";
            this.radioButtonLength.Size = new System.Drawing.Size(58, 17);
            this.radioButtonLength.TabIndex = 0;
            this.radioButtonLength.Text = "Length";
            this.radioButtonLength.UseVisualStyleBackColor = true;
            this.radioButtonLength.CheckedChanged += new System.EventHandler(this.radioButtonLength_CheckedChanged);
            // 
            // BoxConvertFrom
            // 
            this.BoxConvertFrom.BackColor = System.Drawing.Color.Aqua;
            this.BoxConvertFrom.Controls.Add(this.textBoxConvertFrom);
            this.BoxConvertFrom.Controls.Add(this.comboBoxConvertFrom);
            this.BoxConvertFrom.Location = new System.Drawing.Point(376, 81);
            this.BoxConvertFrom.Name = "BoxConvertFrom";
            this.BoxConvertFrom.Size = new System.Drawing.Size(342, 100);
            this.BoxConvertFrom.TabIndex = 2;
            this.BoxConvertFrom.TabStop = false;
            this.BoxConvertFrom.Text = "Convert FROM";
            // 
            // textBoxConvertFrom
            // 
            this.textBoxConvertFrom.Location = new System.Drawing.Point(202, 30);
            this.textBoxConvertFrom.Name = "textBoxConvertFrom";
            this.textBoxConvertFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxConvertFrom.TabIndex = 1;
            this.textBoxConvertFrom.TextChanged += new System.EventHandler(this.textBoxConvertFrom_TextChanged);
            // 
            // comboBoxConvertFrom
            // 
            this.comboBoxConvertFrom.FormattingEnabled = true;
            this.comboBoxConvertFrom.Location = new System.Drawing.Point(20, 30);
            this.comboBoxConvertFrom.Name = "comboBoxConvertFrom";
            this.comboBoxConvertFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConvertFrom.TabIndex = 0;
            this.comboBoxConvertFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxConvertFrom_SelectedIndexChanged);
            // 
            // BoxConvertTo
            // 
            this.BoxConvertTo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BoxConvertTo.Controls.Add(this.textBoxConvertTo);
            this.BoxConvertTo.Controls.Add(this.comboBoxConvertTo);
            this.BoxConvertTo.Location = new System.Drawing.Point(376, 276);
            this.BoxConvertTo.Name = "BoxConvertTo";
            this.BoxConvertTo.Size = new System.Drawing.Size(342, 100);
            this.BoxConvertTo.TabIndex = 3;
            this.BoxConvertTo.TabStop = false;
            this.BoxConvertTo.Text = "Convert To";
            // 
            // textBoxConvertTo
            // 
            this.textBoxConvertTo.Location = new System.Drawing.Point(202, 29);
            this.textBoxConvertTo.Name = "textBoxConvertTo";
            this.textBoxConvertTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConvertTo.TabIndex = 1;
            // 
            // comboBoxConvertTo
            // 
            this.comboBoxConvertTo.FormattingEnabled = true;
            this.comboBoxConvertTo.Location = new System.Drawing.Point(20, 29);
            this.comboBoxConvertTo.Name = "comboBoxConvertTo";
            this.comboBoxConvertTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConvertTo.TabIndex = 0;
            this.comboBoxConvertTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxConvertTo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxConvertTo);
            this.Controls.Add(this.BoxConvertFrom);
            this.Controls.Add(this.BoxSelectUnit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BoxSelectUnit.ResumeLayout(false);
            this.BoxSelectUnit.PerformLayout();
            this.BoxConvertFrom.ResumeLayout(false);
            this.BoxConvertFrom.PerformLayout();
            this.BoxConvertTo.ResumeLayout(false);
            this.BoxConvertTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemReset;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.GroupBox BoxSelectUnit;
        private System.Windows.Forms.RadioButton radioButtonTemp;
        private System.Windows.Forms.RadioButton radioButtonMass;
        private System.Windows.Forms.RadioButton radioButtonLength;
        private System.Windows.Forms.GroupBox BoxConvertFrom;
        private System.Windows.Forms.GroupBox BoxConvertTo;
        private System.Windows.Forms.TextBox textBoxConvertFrom;
        private System.Windows.Forms.ComboBox comboBoxConvertFrom;
        private System.Windows.Forms.TextBox textBoxConvertTo;
        private System.Windows.Forms.ComboBox comboBoxConvertTo;
    }
}

