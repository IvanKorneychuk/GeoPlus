using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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
        List <Usluga> uslugi = new List <Usluga>();
        public static List<Usluga> vybrannye_uslugi = new List<Usluga>();

        public calculator()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("Услуги.txt");
            for (int i = 0; i < lines.Length; i = i + 3)
            {
                string uslName = lines[i];
                string[] parts = lines[i + 1].Split(new string[] { "," }, StringSplitOptions.None );
                Dictionary<string, int> dict = new Dictionary<string, int>();
                for (int j = 0; j < parts.Length; j = j + 2) 
                {
                    dict.Add(parts[j], Convert.ToInt32(parts[j + 1])); 
                }

                uslugi.Add(new Usluga(uslName, dict));
            }
         

            int y = 50;
            for (int i = 0; i < uslugi.Count ; i = i + 1)
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
                uslugi[i].cb.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

                Controls.Add(uslugi[i].cb);



                uslugi[i].stoimost.Location = new Point(450, y);
                uslugi[i].stoimost.Size = new Size(100, 30);
                Controls.Add(uslugi[i].stoimost);


                y = y + 30;
            }
        }

        private void usluga_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uslugi.Count ; i = i + 1)
            {
                if (sender == uslugi[i].vybrano)
                {
                    vybrannye_uslugi.Add(uslugi[i]);
                }
            }
        }
        
        private void usluga2StoimostLabel_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ItogB_Click(object sender, EventArgs e)
        {
        /*    int price1 = Convert.ToInt32(usluga1StoimostLabel.Text.Replace(" рублей", ""));
            int price2 = Convert.ToInt32(usluga2StoimostLabel.Text.Replace(" рублей", ""));
            int price3 = Convert.ToInt32(usluga3StoimostLabel.Text.Replace(" рублей", ""));
            int price4 = Convert.ToInt32(usluga4StoimostLabel.Text.Replace(" рублей", ""));
            int price5 = Convert.ToInt32(usluga5StoimostLabel.Text.Replace(" рублей", ""));

            int priceItog = price1 + price2 + price3 + price4 + price5  ;
            ItogS.Text = priceItog.ToString() + " рублей";*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            foreach (Usluga usl in uslugi)
            {
                if (cb.Location == usl.cb.Location)
                {
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                                ctrl.Location == usl.stoimost.Location)
                        {
                            ctrl.Text = usl.Prices[cb.Text].ToString() + "рублей";
                        }
                    }
                }
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
        
        private void usluga5StoimostLabel_Click(object sender, EventArgs e)
        {

        }

        private void usluga5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usluga5label_Click(object sender, EventArgs e)
        {

        }

        private void usluga1StoimostLabel_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NEW_USL form3 = new NEW_USL();
            form3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        
            {
            
            mail   mail  = new mail ();
            mail .Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ItogS_Click(object sender, EventArgs e)
        {

        }
    }
    }

