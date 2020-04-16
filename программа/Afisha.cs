using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace программа
{
    public partial class Afisha : Form
    {
        public Afisha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator form2 = new calculator();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DopInfo form3 = new DopInfo();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutUsForm form4 = new AboutUsForm();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Привет", "Мы вам нравимся?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Спасибо");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button2.Text = "help";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button2.Text = "справка";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
