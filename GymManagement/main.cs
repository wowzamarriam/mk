﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDelete go1 = new UpdateDelete();
            go1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDelete go1 = new UpdateDelete();
            go1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddMember go2 = new AddMember();
            go2.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
