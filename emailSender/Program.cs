using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailSender
{
    public class Email
    {
        public string EmailType { get; set; }
        public string Password { get; set; }
        public Email(string email, string password)
        {
            EmailType = email;
            Password = password;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Email userEmail = new Email("","");
        }
    }
}
