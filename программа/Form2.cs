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
                Controls.Add(cb);
            }  
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
