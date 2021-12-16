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
        PictureBox[,] Seats;
        private void Kinosál_Load(object sender, EventArgs e) {
            bool restriction;
            using (StreamReader read = File.OpenText(@"../../sedacky.txt")) {
                string line = read.ReadLine();
                SizeLine = Int32.Parse(line.Split('$')[0]);
                SizeSeat = Int32.Parse(line.Split('$')[1]);
                Seats = new PictureBox[SizeLine, SizeSeat];
                line = read.ReadLine();
                if (line.Split('=')[1] == "true" ) { restriction = true; }
                else { restriction = false; }
            }
            using (StreamReader read = File.OpenText(@"../../save.txt")) {
                Random rnd = new Random();
                bool GnrDoub = false;
                for (int i = 0; i < SizeLine; i++) {
                    string line = "", subLine = "";
                    for (int j = 0; j < SizeSeat; j++) {
                        if (subLine == "") { line = read.ReadLine(); GnrDoub = false; }
                        else { line = subLine; subLine = ""; }
                        if (line == null || line.Split('$')[0] != i.ToString() + j.ToString()) { 
                            subLine = line;
                            if (GnrDoub && rnd.Next(0, 5) == 3 && i > 0 && j > 0 && Seats[i, j - 1].ImageLocation != "../../Pictures/block.png") { 
                                Seats[i, j - 1].ImageLocation = @"../../Pictures/emptyL.png"; 
                                line = i + j + "$../../Pictures/emptyR.png"; 
                                GnrDoub = false;
                            } 
                            else { line = i + j + "$../../Pictures/reserve.png"; GnrDoub = true; }
                        }
                        if (restriction && ((i % 2 == 0 && j == 0) || (i % 2 != 0 && j == 1 && (line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/reserveR.png" && line.Split('$')[1] != "../../Pictures/takeR.png")))) { line = i + j + "$../../Pictures/block.png"; }
                        else if (j > 0) {
                            if (restriction && ((i % 2 == 0 || (i % 2 != 0 && j > 1)) && (((line.Split('$')[1] == "../../Pictures/emptyR.png" || line.Split('$')[1] == "../../Pictures/reserveR.png" || line.Split('$')[1] == "../../Pictures/takeR.png") && Seats[i, j - 1].ImageLocation == "../../Pictures/block.png") || ((line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/emptyR.png") && Seats[i, j - 1].ImageLocation != "../../Pictures/block.png")))) { 
                                line = i + j + "$../../Pictures/block.png"; 
                            }
                        }
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
		private void buttonLogin_Click(object sender, EventArgs e) {
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
