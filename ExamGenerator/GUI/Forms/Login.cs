using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator.GUI.Forms
{
    public partial class Login : Form
    {
        LoginGUI login;
        public Login()
        {
            InitializeComponent();
            login = new LoginGUI(Txt_User, Txt_Password, Btn_LogIn, Btn_Register, LinkLbl_ForgotPassword);
        }
    }
}
