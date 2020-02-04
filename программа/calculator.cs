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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
