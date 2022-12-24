using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Top = 20;
            button7.Left = 200;
            button7.Text = "Кнопка";
            button7.Width = 100;
            button7.Height = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            button7.Top = n;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox2.Text);
            button7.Left = b;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button7.Text = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox4.Text);
            button7.Width = m;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox5.Text);
            button7.Height = v;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Top = 20;
            button7.Left = 200;
            button7.Text = "Кнопка";
            button7.Width = 100;
            button7.Height = 40;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
