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
    }
}
