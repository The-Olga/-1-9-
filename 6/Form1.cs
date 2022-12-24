using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Violet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Violet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
