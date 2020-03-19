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
    public partial class Korzina : Form
    {
        public Korzina()
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
                cb.Items.Clear();
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                foreach (string variant in usl.cb.Items)
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
