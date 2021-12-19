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
            using (StreamWriter write = File.CreateText(@"../../Save.txt")) {
                for (int i = 0; i < SizeLine; ++i) {
                    for (int j = 0; j < SizeSeat; j++) {
                        if (Seats[i, j].ImageLocation == "../../Pictures/block.png") {
                            if (j < SizeSeat - 1 && Seats[i, j + 1].ImageLocation == "../../Pictures/block.png") {
                                write.WriteLine(Encode(i.ToString() + j.ToString() + "$../../Pictures/emptyL.png"));
                            }
                            else if (j > 0 && Seats[i, j - 1].ImageLocation == "../../Pictures/emptyL.png") {
                                write.WriteLine(Encode(i.ToString() + j.ToString() + "$../../Pictures/emptyR.png"));
                            }
                            else {
                                write.WriteLine(Encode(i.ToString() + j.ToString() + "$../../Pictures/empty.png"));
                            }
                        }
                        else { write.WriteLine(Encode(i.ToString() + j.ToString() + "$" + Seats[i, j].ImageLocation)); }
                    }
                }
            }
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
                string line = Decode(read.ReadLine());
                SizeLine = Int32.Parse(line.Split('$')[0]);
                SizeSeat = Int32.Parse(line.Split('$')[1]);
                Seats = new PictureBox[SizeLine, SizeSeat];
                line = Decode(read.ReadLine());
                if (line.Split('=')[1] == "true" ) { restriction = true; }
                else { restriction = false; }
            }
            using (StreamReader read = File.OpenText(@"../../Save.txt")) {
                Random rnd = new Random();
                bool GnrDoub = false;
                for (int i = 0; i < SizeLine; i++) {
                    string line = "", subLine = "";
                    for (int j = 0; j < SizeSeat; j++) {
                        if (subLine == "") { line = Decode(read.ReadLine()); GnrDoub = false; }
                        else { line = subLine; subLine = ""; }
                        if (line == null || line.Split('$')[0] != i.ToString() + j.ToString()) { 
                            subLine = line;
                            if (GnrDoub && rnd.Next(0, 5) == 3 && i > 0 && j > 0 && Seats[i, j - 1].ImageLocation != "../../Pictures/block.png") { 
                                Seats[i, j - 1].ImageLocation = @"../../Pictures/emptyL.png"; 
                                line = i + j + "$../../Pictures/emptyR.png"; 
                                GnrDoub = false;
                            } 
                            else { line = i + j + "$../../Pictures/empty.png"; GnrDoub = true; }
                        }
                        if (restriction && ((i % 2 == 0 && j == 0) || (i % 2 != 0 && j == 1 && (line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/reserveR.png" && line.Split('$')[1] != "../../Pictures/takeR.png")))) { line = i + j + "$../../Pictures/block.png"; }
                        else if (j > 0) {
                            if (restriction && ((i % 2 == 0 || (i % 2 != 0 && j > 1)) && (((line.Split('$')[1] == "../../Pictures/emptyR.png" || line.Split('$')[1] == "../../Pictures/reserveR.png" || line.Split('$')[1] == "../../Pictures/takeR.png") && Seats[i, j - 1].ImageLocation == "../../Pictures/block.png") || ((line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/emptyR.png" && line.Split('$')[1] != "../../Pictures/emptyR.png") && Seats[i, j - 1].ImageLocation != "../../Pictures/block.png")))) { 
                                line = i + j + "$../../Pictures/block.png"; 
                            }
                        }
                        Seats[i, j] = new PictureBox {
                            Name = "pictureBox:" + i.ToString() + ":" + j.ToString(),
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
            if ((sender as PictureBox).ImageLocation == "../../Pictures/empty.png" || (sender as PictureBox).ImageLocation == "../../Pictures/emptyL.png" || (sender as PictureBox).ImageLocation == "../../Pictures/emptyR.png") {
                DialogResult result = MessageBox.Show("Chceš si koupit sedačku: ano: koupit ne: reservovat", "Volba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes) {
                    if ((sender as PictureBox).ImageLocation == "../../Pictures/empty.png") { (sender as PictureBox).ImageLocation = "../../Pictures/take.png"; }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/emptyL.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/takeL.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1].ImageLocation = @"../../Pictures/takeR.png";
                    }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/emptyR.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/takeR.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) - 1].ImageLocation = @"../../Pictures/takeL.png";
                    }
                }
                else if (result == DialogResult.No) {
                    if ((sender as PictureBox).ImageLocation == "../../Pictures/empty.png") { (sender as PictureBox).ImageLocation = "../../Pictures/reserve.png"; }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/emptyL.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/reserveL.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1].ImageLocation = @"../../Pictures/reserveR.png";
                    }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/emptyR.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/reserveR.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) - 1].ImageLocation = @"../../Pictures/reserveL.png";
                    }
                }
            }
            else {
                DialogResult result = MessageBox.Show("Chceš zrušit rezervaci?", "Volba", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes) {
                    if ((sender as PictureBox).ImageLocation == "../../Pictures/reserve.png" || (sender as PictureBox).ImageLocation == "../../Pictures/take.png") { (sender as PictureBox).ImageLocation = "../../Pictures/empty.png"; }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/reserveL.png" || (sender as PictureBox).ImageLocation == "../../Pictures/takeL.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/emptyL.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) + 1].ImageLocation = @"../../Pictures/emptyR.png";
                    }
                    else if ((sender as PictureBox).ImageLocation == "../../Pictures/reserveR.png" || (sender as PictureBox).ImageLocation == "../../Pictures/takeR.png") {
                        (sender as PictureBox).ImageLocation = @"../../Pictures/emptyR.png";
                        Seats[Int32.Parse((sender as PictureBox).Name.Split(':')[1]), Int32.Parse((sender as PictureBox).Name.Split(':')[2]) - 1].ImageLocation = @"../../Pictures/emptyL.png";
                    }
                }
            }
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
