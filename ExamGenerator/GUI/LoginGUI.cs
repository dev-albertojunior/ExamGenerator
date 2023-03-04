using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.GUI
{
    internal class LoginGUI
    {
        public TextBox User { get; set; }
        public TextBox Password { get; set; }
        public Button LogIn { get; set; }
        public Button Register { get; set; }
        public LinkLabel ForgotPassword { get; set; }

        public LoginGUI(TextBox user, TextBox password, Button logIn, Button register, LinkLabel forgotPassword)
        {
            User = user;
            Password = password;
            LogIn = logIn;
            Register = register;
            ForgotPassword = forgotPassword;
        }

        public void ExecuteLogin()
        {
            
        }
    }
}
