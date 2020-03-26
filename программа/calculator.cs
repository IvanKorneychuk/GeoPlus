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
    public struct Usluga
    {
        public CheckBox vybrano;
        /// <summary>
        /// Название услуги
        /// </summary>
        public Label lb;
        /// <summary>
        /// Стоимость услуги
        /// </summary>
        public Label stoimost;
        public ComboBox cb;
        public Dictionary<string, int> Prices;

        public Usluga(string name, Dictionary<string, int> _Prices)
        {
            vybrano = new CheckBox();

            lb = new Label();
            lb.Text = name;

            stoimost = new Label();
            stoimost.Text = "0 рублей";

            Prices = _Prices;
            cb = new ComboBox();
            cb.Items.Clear();
            foreach (string variant in Prices.Keys)
            {
                cb.Items.Add(variant);
            }
        }
    }

    public partial class calculator : Form
    {
        Usluga[] uslugi = new Usluga[4];
        public static List<Usluga> vybrannye_uslugi = new List<Usluga>();

        public calculator()
        {
            InitializeComponent();

            uslugi[0] = new Usluga("Горизонтальная съемка земельного участка", 
                new Dictionary<string, int>
                {
                    { "До 1000М²", 7000 },
                    { "До 10000М²", 10000 },
                    { "От 10000М²", 12000 }
                });

            uslugi[1] = new Usluga("Подготовка межевого плана",
                new Dictionary<string, int>
                {
                    { "Образование з/у", 7000 },
                    { "Уточнение гр-ц з / у", 7000 },
                    { "Раздел з/ у", 8000 },
                    { "Объединение з/ у", 8000 }
                });

            uslugi[2] = new Usluga("Подготовка технического плана",
                new Dictionary<string, int>
                {
                    { "ИЖС", 7000 },
                    { "Помещение", 5000 },
                    { "Часть в здании/доме", 6000 }
                });

            uslugi[3] = new Usluga("Строительство",
                new Dictionary<string, int>
                {
                    { "ИЖС", 1200000 },
                    { "Коммерческая недвижимость", 500000 },
                    { "Инженерные коммуникации", 650000 }
                });

            int y = 50;
            for (int i = 0; i < uslugi.Length; i = i + 1)
            {
                uslugi[i].vybrano.Click += usluga_Click;
                uslugi[i].vybrano.Location = new Point(20, y - 5);
                uslugi[i].vybrano.Size = new Size(20, 20);
                Controls.Add(uslugi[i].vybrano);

                uslugi[i].lb.Location = new Point(45, y);
                uslugi[i].lb.Size = new Size(250, 30);
                Controls.Add(uslugi[i].lb);

                uslugi[i].cb.Location = new Point(310, y);
                uslugi[i].cb.Size = new Size(120, 30);
                Controls.Add(uslugi[i].cb);



                uslugi[i].stoimost.Location = new Point(450, y);
                uslugi[i].stoimost.Size = new Size(100, 30);
                Controls.Add(uslugi[i].stoimost);


                y = y + 30;
            }
        }

        private void usluga_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uslugi.Length; i = i + 1)
            {
                if (sender == uslugi[i].vybrano)
                {
                    vybrannye_uslugi.Add(uslugi[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

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
            usluga1StoimostLabel.Text = usluga1Price.ToString() + " рублей";
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            }

            //Итого
            usluga2StoimostLabel.Text = usluga2Price.ToString() + " рублей";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

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

            usluga3StoimostLabel.Text = usluga3Price.ToString() + " рублей";
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

        private void ItogB_Click(object sender, EventArgs e)
        {

            int price1 = Convert.ToInt32(usluga1StoimostLabel.Text.Replace(" рублей", ""));
            int price2 = Convert.ToInt32(usluga2StoimostLabel.Text.Replace(" рублей", ""));
            int price3 = Convert.ToInt32(usluga3StoimostLabel.Text.Replace(" рублей", ""));
            int price4 = Convert.ToInt32(usluga4StoimostLabel.Text.Replace(" рублей", ""));

            int priceItog = price1 + price2 + price3;
            ItogS.Text = priceItog.ToString() + " рублей";
        }

        private void ItogS_Click(object sender, EventArgs e)
        {

        }

        private void usluga4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usluga4label_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int usluga4Price = 0;

            //Горизонтальная съемка земельного участка
            if (usluga4.Checked)
            {
                //До 1000М²
                if (usluga4comboBox.SelectedIndex == 0)
                {
                    usluga4Price = 1200000;
                }
                //До 10000М²
                if (usluga4comboBox.SelectedIndex == 1)
                {
                    usluga4Price = 500000;
                }
                //Больше 1га
                if (usluga3comboBox.SelectedIndex == 2)
                {
                    usluga4Price = 650000;
                }

                usluga4StoimostLabel.Text = usluga4Price.ToString() + " рублей";
            }

            //Итого
            usluga4StoimostLabel.Text = usluga4Price.ToString() + " рублей";
        }

        private void usluga4StoimostLabel_Click(object sender, EventArgs e)
        {

        }

        private void usluga3StoimostLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 korzina = new Form2();
            korzina.Show();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
