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
    public partial class NEW_USL : Form
    {
        public NEW_USL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Услуги.txt",
                Environment.NewLine +
                comboBox1.Text + " " + textBox1.Text + " " + textBox2.Text);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
