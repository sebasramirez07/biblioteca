﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class accion : Form
    {
        public accion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form acc1 = new pago();
            acc1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form acc1 = new pago();
            acc1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form acc1 = new pago();
            acc1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form acc1 = new pago();
            acc1.ShowDialog();
        }

        private void atras1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
