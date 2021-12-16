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
    public partial class Kinosál : Form {
        public Kinosál() {
            InitializeComponent();
        }
        private void Kinosál_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        //write to text file
        /*using (StreamWriter write = File.AppendText(@"Adress file")) {  //AppendText - CreateText
            write.WriteLine("Some text...");
        }*/
        //read from text file
        /*using (StreamReader read = File.OpenText(@"Adress file")) {
            string line = read.ReadLine();
            for (int i = 0; line != null; ++i) {
                Array[i] = line;
                line = read.ReadLine();
            }
        }*/
        public static int SizeLine = 5, SizeSeat = 8;
        PictureBox[,] Seats = new PictureBox[SizeLine,SizeSeat];
        private void Kinosál_Load(object sender, EventArgs e) {
            bool restriction;
            using (StreamReader read = File.OpenText(@"../../sedacky.txt")) {
                string line = read.ReadLine();
                SizeLine = Int32.Parse(line.Split('$')[0]);
                SizeSeat = Int32.Parse(line.Split('$')[1]);
                line = read.ReadLine();
                if (line.Split('=')[1] == "true" ) { restriction = true; }
                else { restriction = false; }
            }
            using (StreamReader read = File.OpenText(@"../../Save.txt")) {
                for (int i = 0; i < SizeLine; i++) {
                    string line = "", subLine = "";
                    for (int j = 0; j < SizeSeat; j++) {
                        if (subLine == "") { line = read.ReadLine(); }
                        else { line = subLine; subLine = ""; }
                        if (line == null) { subLine = line; line = i + j +"$../../Pictures/take.png"; }
                        if (line.Split('$')[0] != i.ToString() + j.ToString()) { subLine = line; line = "$../../Pictures/take.png"; }
                        if (restriction && i % 2 == 0 && j % 2 == 0) { line = "$../../Pictures/block.png"; }
                        else if (restriction && j % 2 != 0) { line = "$../../Pictures/block.png"; }
                        Seats[i, j] = new PictureBox {
                            Name = "pictureBox" + i.ToString() + j.ToString(),
                            Size = new Size(30, 30),
                            Location = new Point(33 * j + 30, 33 * i + 30),
                            ImageLocation = @line.Split('$')[1],
                            BackColor = Color.Black
                        };
                        Seats[i,j].Click += new EventHandler(ChangeSeat);
                        this.Controls.Add(Seats[i, j]);
                    }
                }
            }
        }

		private void buttonLogin_Click(object sender, EventArgs e)
		{
            this.Hide();
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show();
		}

        private void ChangeSeat(object sender, EventArgs e) {

            MessageBox.Show((sender as PictureBox).Name);
            //vybrání rezervace - koupení / (sender as PictureBox)
        }
    }
}
