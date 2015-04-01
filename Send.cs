using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (textBox_body.Text.Trim() == String.Empty)
            {
                pictureBox2.Image = Image.FromFile(@"resurs\krasnyiy-krestik.png");
            }
            else
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
                    client.Credentials = new NetworkCredential("tester.send@mail.ru", "1994adadad");
                    string from = "tester.send@mail.ru";
                    string to = "tester.get@mail.ru";
                    string subject = "От: " + Convert.ToString(textBox_mail.Text) + "  |  " + "ask: " + Convert.ToString(textBox_body.Text);
                    string text = Convert.ToString(textBox_body.Text);
                    client.EnableSsl = true;

                    client.Send(from, to, subject, text);
                    pictureBox2.Image = Image.FromFile(@"resurs\w512h5121348753316CuteBallGo.png");

                }
                catch 
                {
                    pictureBox2.Image = Image.FromFile(@"resurs\krasnyiy-krestik.png");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
