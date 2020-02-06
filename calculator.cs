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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;

            int usluga1Price = 0;

            //Горизонтальная съемка земельного участка
            if (usluga1.Checked)
            {
                //До 1000М²
                if (usluga1comboBox.SelectedIndex == 0)
                {
                    usluga1Price = 7000;
                }
                //До 10000М²
                if (usluga1comboBox.SelectedIndex == 1)
                {
                    usluga1Price = 10000;
                }
                //Больше 1га
                if (usluga1comboBox.SelectedIndex == 2)
                {
                    usluga1Price = 12000;
                }

                usluga1StoimostLabel.Text = usluga1Price.ToString() + " рублей";
            }

            //Итого
            sum = usluga1Price;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum1 = 0;

            int usluga2Price = 0;

            //Горизонтальная съемка земельного участка
            if (usluga2.Checked)
            {
                //До 1000М²
                if (usluga2comboBox.SelectedIndex == 0)
                {
                    usluga2Price = 7000;
                }
                //До 10000М²
                if (usluga2comboBox.SelectedIndex == 1)
                {
                    usluga2Price = 7000;
                }
                //Больше 1га
                if (usluga2comboBox.SelectedIndex == 2)
                {
                    usluga2Price = 8000;
                }
                if (usluga2comboBox.SelectedIndex == 3)
                {
                    usluga2Price = 8000;
                }

                usluga2StoimostLabel.Text = usluga2Price.ToString() + " рублей";
            }

            //Итого
            sum1 = usluga2Price;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum2 = 0;

            int usluga3Price = 0;

            //Горизонтальная съемка земельного участка
            if (usluga3.Checked)
            {
                //До 1000М²
                if (usluga3comboBox.SelectedIndex == 0)
                {
                    usluga3Price = 7000;
                }
                //До 10000М²
                if (usluga3comboBox.SelectedIndex == 1)
                {
                    usluga3Price = 5000;
                }
                //Больше 1га
                if (usluga3comboBox.SelectedIndex == 2)
                {
                    usluga3Price = 6000;
                }

                usluga3StoimostLabel.Text = usluga3Price.ToString() + " рублей";
            }

            //Итого
            sum2 = usluga3Price;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usluga2StoimostLabel_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                spravkaTextBox.Lines = System.IO.File.ReadAllLines("../../Resources/" + usluga1label.Text + ".txt");
            }
            catch (Exception) { }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                spravkaTextBox.Lines = System.IO.File.ReadAllLines("../../Resources/" + usluga2label.Text + ".txt");
            }
            catch (Exception) { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                spravkaTextBox.Lines = System.IO.File.ReadAllLines("../../Resources/" + usluga3label.Text + ".txt");
            }
            catch (Exception) { }
        }
    }
}
