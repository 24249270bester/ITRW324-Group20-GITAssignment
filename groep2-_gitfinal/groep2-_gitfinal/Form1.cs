﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep2__gitfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Andries Bester 24249270");
            AndriesForm AF = new AndriesForm();
            AF.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMedian frm = new frmMedian();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RuanForm RF = new RuanForm();
            RF.Show();
        }
    }
}
