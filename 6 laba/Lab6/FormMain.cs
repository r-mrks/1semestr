﻿using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}