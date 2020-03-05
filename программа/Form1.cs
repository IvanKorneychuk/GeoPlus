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
    public struct Uslugi
    {
        public string name;
        public int price;
        public Label pb;

        public Uslugi(string name1, int price1)
        {
            name = name1;
            price = price1;
            pb = new Label();
        }
    }

    public partial class Form1 : Form
    {
        Uslugi[] uslugi = new Uslugi[4];

        public Form1()
        {
            InitializeComponent();

            uslugi[0] = new Uslugi("Межевой план", 10000);
            uslugi[1] = new Uslugi("Рабы", 9000);
            uslugi[2] = new Uslugi("Экзорцист", 17000);
            uslugi[3] = new Uslugi("Женщины с низкой социальной ответственностью", 2000);
            
            int x = 10;
            int y = 100;
            for (int i = 0; i < 4; i++)
            {
                uslugi[i].pb.Location = new Point(x, y);
                uslugi[i].pb.Size = new Size(100, 50);
                uslugi[i].pb.Text = "123";
                Controls.Add(uslugi[i].pb);
                x = x + 100;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (uslugi[i].price <= Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show(uslugi[i].name);
                }
            
            
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
