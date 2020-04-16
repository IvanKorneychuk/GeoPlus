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

            int i = 0;
            string variants = "";

            if (uslov1.Text != "" && Int32.TryParse(price1.Text, out i))
                variants += ", " + uslov1.Text + ", " + price1.Text;

            if (uslov2.Text != "" && Int32.TryParse(price2.Text, out i))
                variants += ", " + uslov2.Text + ", " + price2.Text;

            if (variants.Length > 0)
                variants = variants.Substring(2); 



            System.IO.File.AppendAllText("Услуги.txt",
                Environment.NewLine + nameUSL.Text +
                Environment.NewLine +
                variants +
            Environment.NewLine );



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
