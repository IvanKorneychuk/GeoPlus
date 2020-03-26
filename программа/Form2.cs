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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            //Бегаем по всем выбранным услугам
            foreach (Usluga usl in calculator.vybrannye_uslugi)
            {
                //Из них тырим чекбокс
                CheckBox vybrano = new CheckBox();
                vybrano.Size = usl.vybrano.Size;
                vybrano.Location = usl.vybrano.Location;
                Controls.Add(vybrano);

                ComboBox cb = new ComboBox();
                cb.Size = usl.cb.Size;
                cb.Location = usl.cb.Location;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Items.Clear();
                cb.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                foreach (string variant in usl.Prices.Keys)
                {
                    cb.Items.Add(variant);
                }
                cb.Text = usl.cb.Text;
                Controls.Add(cb);

                Label lb = new Label();
                lb.Size = usl.lb.Size;
                lb.Text = usl.lb.Text;
                lb.Location = usl.lb.Location;
                Controls.Add(lb);

                Label stoimost = new Label();
                stoimost.Size = usl.stoimost.Size;
                stoimost.Text = usl.stoimost.Text;
                stoimost.Location = usl.stoimost.Location;
                Controls.Add(stoimost);
            }  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ComboBox cb = (ComboBox)sender;
                foreach (Usluga usl in calculator.vybrannye_uslugi)
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
