using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" У чая есть свой праздник: ежегодно 15 декабря отмечается Международный день чая.");
            button1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В России 98% населения пьет чай, благодаря чему страна занимает четвертое место в мире по употреблению этого напитка. Больше россиян чай любят только китайцы, индийцы и турки.");
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Риск развития симптомов дeпрессии у любителей чаевничать на 44% ниже, чем у тех , кто пьет ежедневно не больше чашки.");
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Самый популярный вид чая в мире — черный, он занимает около 75% всего мирового потребления чая. Примечательно, что на родине чая — Китае — черный чай почти не пьют, предпочитая ему всевозможные разновидности зеленого.");
            button3.Enabled = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleGoldenrod;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleGoldenrod;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.PaleGoldenrod;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.PaleGoldenrod;
        }
    }
}
