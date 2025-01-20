using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ClassiRune
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trololo = MessageBox.Show("Made by the UPGSOFTWARE division of WIZARDSTUDIOS\nCopyleft MMXXIV Some Rights Reserved.", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (trololo == DialogResult.No)
            {
                Process ricky = new Process();
                ricky.StartInfo.FileName = "cmd.exe";
                ricky.StartInfo.Arguments = "/c start https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                ricky.StartInfo.CreateNoWindow = true;
                ricky.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            freescape f1 = new freescape();
            this.Hide();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            REAL01SCAPE f1 = new REAL01SCAPE();
            this.Hide();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Altimeline f1 = new Altimeline();
            this.Hide();
            f1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Java Archive Files (*.jar)|*.jar|All Files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            foreach (var path in dlg.FileNames)
            {
                File.WriteAllText("jarpath.txt", dlg.FileName);
                File.WriteAllText("dirpath.txt", Path.GetDirectoryName(dlg.FileName));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists("jarpath.txt") == true && File.Exists("dirpath.txt") == true)
            {
                string jarpath = File.ReadAllText("jarpath.txt");
                string dirpath = File.ReadAllText("dirpath.txt");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C cd {dirpath} && java -jar {jarpath}";
                process.StartInfo = startInfo;
                this.Hide();
                process.Start();
            } 
            else
            {
                MessageBox.Show("Please Set Path");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C explorer https://rscsundae.org/";
            process.StartInfo = startInfo;
            this.Hide();
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Icecream icecream = new Icecream();
            this.Hide();
            icecream.Show();
        }
    }
}
