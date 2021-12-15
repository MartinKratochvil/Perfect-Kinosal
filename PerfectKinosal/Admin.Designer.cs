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
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonNastavitPocetSedacek = new System.Windows.Forms.Button();
			this.numericUpDownRady = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSedacky = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxRestrikce = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRady)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSedacky)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(682, 415);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(106, 23);
			this.buttonReset.TabIndex = 0;
			this.buttonReset.Text = "Resetování kina";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonNastavitPocetSedacek
			// 
			this.buttonNastavitPocetSedacek.Location = new System.Drawing.Point(148, 110);
			this.buttonNastavitPocetSedacek.Name = "buttonNastavitPocetSedacek";
			this.buttonNastavitPocetSedacek.Size = new System.Drawing.Size(96, 35);
			this.buttonNastavitPocetSedacek.TabIndex = 1;
			this.buttonNastavitPocetSedacek.Text = "Uložit nastavení";
			this.buttonNastavitPocetSedacek.UseVisualStyleBackColor = true;
			this.buttonNastavitPocetSedacek.Click += new System.EventHandler(this.buttonNastavitPocetSedacek_Click);
			// 
			// numericUpDownRady
			// 
			this.numericUpDownRady.Location = new System.Drawing.Point(138, 40);
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
			this.numericUpDownSedacky.Location = new System.Drawing.Point(137, 71);
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
			this.label1.Location = new System.Drawing.Point(74, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Počet řad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Počet sedaček v řadě:";
			// 
			// checkBoxRestrikce
			// 
			this.checkBoxRestrikce.AutoSize = true;
			this.checkBoxRestrikce.Location = new System.Drawing.Point(275, 72);
			this.checkBoxRestrikce.Name = "checkBoxRestrikce";
			this.checkBoxRestrikce.Size = new System.Drawing.Size(71, 17);
			this.checkBoxRestrikce.TabIndex = 6;
			this.checkBoxRestrikce.Text = "Restrikce";
			this.checkBoxRestrikce.UseVisualStyleBackColor = true;
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBoxRestrikce);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownSedacky);
			this.Controls.Add(this.numericUpDownRady);
			this.Controls.Add(this.buttonNastavitPocetSedacek);
			this.Controls.Add(this.buttonReset);
			this.Name = "Admin";
			this.Text = "Admin";
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
	}
}