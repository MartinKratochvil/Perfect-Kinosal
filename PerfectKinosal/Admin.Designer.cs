namespace PerfectKinosal
{
	partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNastavitPocetSedacek = new System.Windows.Forms.Button();
            this.numericUpDownRady = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSedacky = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRestrikce = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSedacky)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(152, 107);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 35);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Resetování kina";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNastavitPocetSedacek
            // 
            this.buttonNastavitPocetSedacek.BackColor = System.Drawing.Color.Black;
            this.buttonNastavitPocetSedacek.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNastavitPocetSedacek.Location = new System.Drawing.Point(37, 107);
            this.buttonNastavitPocetSedacek.Name = "buttonNastavitPocetSedacek";
            this.buttonNastavitPocetSedacek.Size = new System.Drawing.Size(96, 35);
            this.buttonNastavitPocetSedacek.TabIndex = 1;
            this.buttonNastavitPocetSedacek.Text = "Uložit nastavení";
            this.buttonNastavitPocetSedacek.UseVisualStyleBackColor = false;
            this.buttonNastavitPocetSedacek.Click += new System.EventHandler(this.buttonNastavitPocetSedacek_Click);
            // 
            // numericUpDownRady
            // 
            this.numericUpDownRady.BackColor = System.Drawing.Color.Black;
            this.numericUpDownRady.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownRady.Location = new System.Drawing.Point(140, 18);
            this.numericUpDownRady.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRady.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRady.Name = "numericUpDownRady";
            this.numericUpDownRady.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRady.TabIndex = 2;
            this.numericUpDownRady.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownSedacky
            // 
            this.numericUpDownSedacky.BackColor = System.Drawing.Color.Black;
            this.numericUpDownSedacky.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownSedacky.Location = new System.Drawing.Point(139, 49);
            this.numericUpDownSedacky.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSedacky.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSedacky.Name = "numericUpDownSedacky";
            this.numericUpDownSedacky.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSedacky.TabIndex = 3;
            this.numericUpDownSedacky.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Počet řad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Počet sedaček v řadě:";
            // 
            // checkBoxRestrikce
            // 
            this.checkBoxRestrikce.AutoSize = true;
            this.checkBoxRestrikce.BackColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxRestrikce.Location = new System.Drawing.Point(139, 84);
            this.checkBoxRestrikce.Name = "checkBoxRestrikce";
            this.checkBoxRestrikce.Size = new System.Drawing.Size(71, 17);
            this.checkBoxRestrikce.TabIndex = 6;
            this.checkBoxRestrikce.Text = "Restrikce";
            this.checkBoxRestrikce.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(181, 156);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 34);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Zpět";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkBoxRestrikce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSedacky);
            this.Controls.Add(this.numericUpDownRady);
            this.Controls.Add(this.buttonNastavitPocetSedacek);
            this.Controls.Add(this.buttonReset);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSedacky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonNastavitPocetSedacek;
		private System.Windows.Forms.NumericUpDown numericUpDownRady;
		private System.Windows.Forms.NumericUpDown numericUpDownSedacky;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxRestrikce;
        private System.Windows.Forms.Button buttonBack;
    }
}