using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Скорость:";
            label2.Text = "Время:";
            label3.Text = "Расстояние:";
            button1.Text = "Узнать расстояние";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a = int.Parse(textBox2.Text);
            int na = a * n;
            textBox3.Text = na.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
