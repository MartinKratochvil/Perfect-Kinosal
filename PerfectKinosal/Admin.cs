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

namespace PerfectKinosal {
	public partial class Admin : Form {
		public Admin() {
			InitializeComponent();
		}
		private void Admin_FormClosed(object sender, FormClosedEventArgs e) {
			Kinosál frame = new Kinosál();
			frame.Show();
        }
		private void Admin_Load(object sender, EventArgs e) {
			using (StreamReader read = File.OpenText(@"../../sedacky.txt")) {
				string sedacky = Decode(read.ReadLine());
				numericUpDownRady.Value = int.Parse(sedacky.Split('$')[0]);
				numericUpDownSedacky.Value = int.Parse(sedacky.Split('$')[1]);
				string restrikce = Decode(read.ReadLine());
				if (restrikce.Split('=')[1] == "true") { checkBoxRestrikce.Checked = true; }
				else if (restrikce.Split('=')[1] == "false") { checkBoxRestrikce.Checked = false; }
			}
		}
		private void buttonNastavitPocetSedacek_Click(object sender, EventArgs e) {
			using (StreamWriter write = File.CreateText(@"../../sedacky.txt")) {
				write.WriteLine(Encode($"{numericUpDownRady.Value}${numericUpDownSedacky.Value}"));
				if (checkBoxRestrikce.Checked == true) { write.WriteLine(Encode("restrikce=true")); }
				else if (checkBoxRestrikce.Checked == false) { write.WriteLine(Encode("restrikce=false")); }
			}
		}
		private void buttonReset_Click(object sender, EventArgs e) {
			StreamWriter write = File.CreateText(@"../../sedacky.txt");
		}
        private void buttonBack_Click(object sender, EventArgs e) {
			this.Close();
        }
		public string Encode(string input) {
			if (input == null) { return null; }
			else {
				var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
				string encoded = System.Convert.ToBase64String(plainTextBytes);
				return encoded;
			}
		}
		public string Decode(string input) {
			if (input == null) { return null; }
			else {
				var encodedTextBytes = Convert.FromBase64String(input);
				string decoded = Encoding.UTF8.GetString(encodedTextBytes);
				return decoded;-+
			}
		}
	}
}
