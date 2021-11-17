using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emailSender
{
    public partial class frmLogin : Form
    {
        public static string userEmail = "";
        public static string passWord = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userEmail = txtMail2.Text.ToString();
            passWord = txtPassword.Text.ToString();
            new frmMain().Show();
            this.Hide();
        }
    }
}
