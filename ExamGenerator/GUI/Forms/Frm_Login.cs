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
    public partial class Frm_Login : Form
    {
        LoginGUI login;
        public Frm_Login()
        {
            InitializeComponent();
            login = new LoginGUI(Txt_User, Txt_Password, Btn_LogIn, Btn_Register, LinkLbl_ForgotPassword);
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Frm_Register register = new Frm_Register();
            register.Show();
            Hide();
        }
    }
}
