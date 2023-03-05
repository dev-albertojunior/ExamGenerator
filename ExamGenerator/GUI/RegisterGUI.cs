using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExamGenerator.GUI
{
    internal class RegisterGUI
    {
        public TextBox Name { get; set; }
        public TextBox Email { get; set; }
        public DateTimePicker Birthday { get; set; }
        public TextBox User { get; set; }
        public TextBox Password { get; set; }
        public TextBox ConfirmPassword { get; set; }
        public Button Register { get; set; }

        public RegisterGUI(TextBox name, TextBox email, DateTimePicker birthday, TextBox user, TextBox password, TextBox confirmPassword, Button register)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
            User = user;
            Password = password;
            ConfirmPassword = confirmPassword;
            Register = register;
        }

        public void ExecuteRegister()
        {
            SqlConnection connection = new SqlConnection("Data Source=nome_do_servidor;Initial Catalog=nome_do_banco_de_dados;User ID=nome_de_usuario;Password=senha_do_usuario;");

        }
    }
}
