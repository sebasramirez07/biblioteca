using System;
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
    public partial class infantil1 : Form
    {
        public infantil1()
        {
            InitializeComponent();
        }

        private void infantil1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form inf1 = new pago();
            inf1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form inf1 = new pago();
            inf1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form inf1 = new pago();
            inf1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form inf1 = new pago();
            inf1.ShowDialog();
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
