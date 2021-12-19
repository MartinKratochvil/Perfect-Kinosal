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
	public partial class AdminLogin : Form
	{
		public AdminLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			string password = textBox2.Text;

			using (StreamReader read = File.OpenText(@"../../admin_login.txt"))
			{
				bool find_login = false, konec=false;

				while (find_login == false && konec == false)
				{
					string line = Decode(read.ReadLine());
					if (line == null) { konec = true; }
					else if (line.StartsWith(name) && line.Split('$')[1] == password) {
						find_login = true;
						this.Close();
						Admin Admin = new Admin();
						Admin.Show();
					}
				}
				if (find_login == false) { MessageBox.Show("Špatné přihlašovací údaje!"); }
			}
		}

		private void AdminLogin_Load(object sender, EventArgs e)
		{

		}

		public string Encode(string input)
		{
			if (input == null) { return null; }
			else
			{
				var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
				string encoded = System.Convert.ToBase64String(plainTextBytes);
				return encoded;
			}
		}

		public string Decode(string input)
		{
			if (input == null) { return null; }
			else
			{
				var encodedTextBytes = Convert.FromBase64String(input);
				string decoded = Encoding.UTF8.GetString(encodedTextBytes);
				return decoded;
			}
		}
	}
}
