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

namespace emailSender
{
    public partial class frmMain : Form
    {
        string userEmail2;
        string passWord2;
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if(txtMail.Text=="   Email")
            {
                txtMail.Clear();
                txtMail.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if(txtMail.Text=="")
            {
                txtMail.ForeColor = Color.FromArgb(200, 200, 200);
                txtMail.Text = "   Email";
            }
        }

        private void txtSub_Enter(object sender, EventArgs e)
        {
            if (txtSub.Text == "   Subject")
            {
                txtSub.Clear();
                txtSub.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSub_Leave(object sender, EventArgs e)
        {
            if (txtSub.Text == "")
            {
                txtSub.ForeColor = Color.FromArgb(200, 200, 200);
                txtSub.Text = "   Subject";
            }
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text == "   Message")
            {
                txtMessage.Clear();
                txtMessage.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                txtMessage.ForeColor = Color.FromArgb(200, 200, 200);
                txtMessage.Text = "   Message";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to, messageBody;
            MailMessage message = new MailMessage();
            to = txtMail.Text;
            userEmail2 = frmLogin.userEmail;
            passWord2 = frmLogin.passWord;
            messageBody = txtMessage.Text;
            message.To.Add(to);
            message.From = new MailAddress(userEmail2);
            message.Body = "From : " + "<br>Message: " + messageBody;
            message.Subject = txtSub.Text;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(userEmail2, passWord2);
            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email was sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(code == DialogResult.OK)
                {
                    txtMail.Clear();
                    txtMessage.Clear();
                    txtSub.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Emailer_Load(object sender, EventArgs e)
        {

        }
    }
}
