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
    public partial class Frm_Register : Form
    {
        RegisterGUI register;
        public Frm_Register()
        {
            InitializeComponent();
            register = new RegisterGUI(Txt_Name, Txt_Email, DateTimePicker_Birthday, Txt_User, Txt_Password, Txt_ConfirmPassword, Btn_Register);
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            register.CheckAllFields(this);
            register.CheckPassword();
            register.ExecuteRegister();
        }
    }
}
