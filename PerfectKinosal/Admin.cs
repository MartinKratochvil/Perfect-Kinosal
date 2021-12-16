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

namespace PerfectKinosal
{
	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
		}

		private void Admin_Load(object sender, EventArgs e)
		{
			using (StreamReader read = File.OpenText(@"../../sedacky.txt"))
			{
				string sedacky = read.ReadLine();
				numericUpDownRady.Value = int.Parse(sedacky.Split('$')[0]);
				numericUpDownSedacky.Value = int.Parse(sedacky.Split('$')[1]);
				string restrikce = read.ReadLine();
				if (restrikce.Split('=')[1] == "true") { checkBoxRestrikce.Checked = true; }
				else if (restrikce.Split('=')[1] == "false") { checkBoxRestrikce.Checked = false; }
			}
		}

		private void buttonNastavitPocetSedacek_Click(object sender, EventArgs e)
		{
			using (StreamWriter write = File.CreateText(@"../../sedacky.txt"))
			{  //AppendText - CreateText
				write.WriteLine($"{numericUpDownRady.Value}${numericUpDownSedacky.Value}");
				if (checkBoxRestrikce.Checked == true) { write.WriteLine("restrikce=true"); }
				else if (checkBoxRestrikce.Checked == false) { write.WriteLine("restrikce=false"); }
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			StreamWriter write = File.CreateText(@"../../sedacky.txt");
		}
	}
}
