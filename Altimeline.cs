﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassiRune
{
    public partial class Altimeline : Form
    {
        public Altimeline()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutRuneScapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RuneScape Internet Client\nBy JAGeX Software\nCopyright (C) 2001", "About");
        }
    }
}