using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

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

        private bool CheckIfRegisterExists()
        {
            string connectionString = "Data Source=LAPTOP-K1PKSKJN\\SQLEXPRESS;Initial Catalog=exam;User ID=adminexam;Password=Vancouver.91";

            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT * FROM Users WHERE Email=@Email OR User=@User";

            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@Email", Email.Text);
            command.Parameters.AddWithValue("@User", User.Text);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                bool exists = reader.HasRows;
                reader.Close();
                return exists;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking if the email or username already exists in the database." + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void ExecuteRegister()
        {
            if (!CheckIfRegisterExists())
            {
                SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K1PKSKJN\\SQLEXPRESS;Initial Catalog=exam;User ID=adminexam;Password=Vancouver.91");
                try
                { 
                    string query = "INSERT INTO Users (Name, Email, Birthday, [User], Password) VALUES (@Name, @Email, @Birthday, @User, @Password)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Birthday", Birthday.Value);
                    cmd.Parameters.AddWithValue("@User", User.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Name.Clear();
                    Email.Clear();
                    User.Clear();
                    Password.Clear();
                    ConfirmPassword.Clear();
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error while saving informations on database." + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool CheckPassword()
        {
            return Password.Text == ConfirmPassword.Text ? true : MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK ? false : false;
        }
        public bool CheckAllFields(Form form)
        {
            bool allFieldsFilled = form.Controls.OfType<TextBox>().All(tb => !string.IsNullOrEmpty(tb.Text));

            if (!allFieldsFilled)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return allFieldsFilled;
        }
    }
}
