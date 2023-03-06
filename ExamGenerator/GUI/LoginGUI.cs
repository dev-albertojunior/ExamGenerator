using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void ExecuteLogin(Form form)
        {
            string connectionString = "Data Source=LAPTOP-K1PKSKJN\\SQLEXPRESS;Initial Catalog=exam;User ID=adminexam;Password=Vancouver.91";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string selectQuery = "SELECT COUNT(*) FROM Users WHERE [User]=@User AND Password=@Password";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@User", User.Text);
                command.Parameters.AddWithValue("@Password", Password.Text);
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    form.Show();
                }
                else
                {
                    MessageBox.Show("User or password incorrect!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking user and password on database." + ex.Message);
            }
            finally
            {
                connection.Close();
            }   
        }

        public void CheckAllFields(Form form)
        {
            bool allFieldsFilled = form.Controls.OfType<TextBox>().All(tb => !string.IsNullOrEmpty(tb.Text));

            if (!allFieldsFilled)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
