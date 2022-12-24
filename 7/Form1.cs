using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "ИМЯ";
            textBox2.Text = "ВОЗРАСТ";
            textBox3.Text = "РАСА";
            button1.Text = "Создать персонажа!";
            label2.Text = "Имя:";
            label4.Text = "Возраст:";
            label6.Text = "Раса:";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);

            label1.Text = "Ваш персонаж успешно создан!";
            label3.Text = textBox1.Text;
            label5.Text = n.ToString();
            label7.Text = textBox3.Text;

        }
    }
}
