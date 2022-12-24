using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Дом";
            button2.Text = "Узнать плозадь";
            button3.Text = "Узнать периметр";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = button1.Width;
            int d = button1.Height;
            int s = c*d;
            button2.Text = s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = button1.Width;
            int d = button1.Height;
            int p = 2 * (c + d);
            button3.Text = p.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
