using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailApplication
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        private void sentButton_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromTextBox.Text);
                message.To.Add(toTextBox.Text);
                message.CC.Add(ccTextBox.Text);
                message.Body = bodyTextBox.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(fromTextBox.Text, passworrdTextBox.Text);
                client.Send(message);

                MessageBox.Show("mail sent");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
