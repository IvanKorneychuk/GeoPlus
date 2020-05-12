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
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("ivanshkakorneychuk@gmail.com", "Корнейчук Иван");
            MailAddress toAddress = new MailAddress("ivanshka-korneychuk@mail.ru", " Корнейчук Иван");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = textBox1.Text;
                mailMessage.Body = textBox2.Text;
                mailMessage.Attachments.Add(new Attachment("Человеки.txt"));

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "YbRbnjc1411");

                smtpClient.Send(mailMessage);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
