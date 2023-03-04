namespace ExamGenerator.GUI.Forms
{
    partial class Frm_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_Name = new Label();
            Txt_Name = new TextBox();
            Lbl_Email = new Label();
            Txt_Email = new TextBox();
            Lbl_Birthday = new Label();
            DateTimePicker_Birthday = new DateTimePicker();
            Lbl_User = new Label();
            Txt_User = new TextBox();
            Lbl_Password = new Label();
            Txt_Password = new TextBox();
            Lbl_ConfirmPassword = new Label();
            Txt_ConfirmPassword = new TextBox();
            Btn_Register = new Button();
            SuspendLayout();
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Name.Location = new Point(38, 37);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(40, 15);
            Lbl_Name.TabIndex = 4;
            Lbl_Name.Text = "Name";
            // 
            // Txt_Name
            // 
            Txt_Name.Location = new Point(38, 55);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(353, 23);
            Txt_Name.TabIndex = 3;
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Email.Location = new Point(38, 95);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(36, 15);
            Lbl_Email.TabIndex = 6;
            Lbl_Email.Text = "Email";
            // 
            // Txt_Email
            // 
            Txt_Email.Location = new Point(38, 113);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(210, 23);
            Txt_Email.TabIndex = 5;
            // 
            // Lbl_Birthday
            // 
            Lbl_Birthday.AutoSize = true;
            Lbl_Birthday.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Birthday.Location = new Point(254, 95);
            Lbl_Birthday.Name = "Lbl_Birthday";
            Lbl_Birthday.Size = new Size(54, 15);
            Lbl_Birthday.TabIndex = 7;
            Lbl_Birthday.Text = "Birthday";
            // 
            // DateTimePicker_Birthday
            // 
            DateTimePicker_Birthday.Format = DateTimePickerFormat.Short;
            DateTimePicker_Birthday.Location = new Point(254, 113);
            DateTimePicker_Birthday.MaxDate = new DateTime(2023, 3, 3, 0, 0, 0, 0);
            DateTimePicker_Birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateTimePicker_Birthday.Name = "DateTimePicker_Birthday";
            DateTimePicker_Birthday.Size = new Size(137, 23);
            DateTimePicker_Birthday.TabIndex = 8;
            DateTimePicker_Birthday.Value = new DateTime(2023, 3, 3, 0, 0, 0, 0);
            // 
            // Lbl_User
            // 
            Lbl_User.AutoSize = true;
            Lbl_User.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_User.Location = new Point(38, 154);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(33, 15);
            Lbl_User.TabIndex = 10;
            Lbl_User.Text = "User";
            // 
            // Txt_User
            // 
            Txt_User.Location = new Point(38, 172);
            Txt_User.Name = "Txt_User";
            Txt_User.Size = new Size(210, 23);
            Txt_User.TabIndex = 9;
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Password.Location = new Point(254, 154);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(59, 15);
            Lbl_Password.TabIndex = 12;
            Lbl_Password.Text = "Password";
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(254, 172);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(137, 23);
            Txt_Password.TabIndex = 11;
            // 
            // Lbl_ConfirmPassword
            // 
            Lbl_ConfirmPassword.AutoSize = true;
            Lbl_ConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_ConfirmPassword.Location = new Point(254, 214);
            Lbl_ConfirmPassword.Name = "Lbl_ConfirmPassword";
            Lbl_ConfirmPassword.Size = new Size(107, 15);
            Lbl_ConfirmPassword.TabIndex = 14;
            Lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // Txt_ConfirmPassword
            // 
            Txt_ConfirmPassword.Location = new Point(254, 232);
            Txt_ConfirmPassword.Name = "Txt_ConfirmPassword";
            Txt_ConfirmPassword.Size = new Size(137, 23);
            Txt_ConfirmPassword.TabIndex = 13;
            // 
            // Btn_Register
            // 
            Btn_Register.Location = new Point(254, 280);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(137, 26);
            Btn_Register.TabIndex = 15;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = true;
            // 
            // Frm_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(440, 335);
            Controls.Add(Btn_Register);
            Controls.Add(Lbl_ConfirmPassword);
            Controls.Add(Txt_ConfirmPassword);
            Controls.Add(Lbl_Password);
            Controls.Add(Txt_Password);
            Controls.Add(Lbl_User);
            Controls.Add(Txt_User);
            Controls.Add(DateTimePicker_Birthday);
            Controls.Add(Lbl_Birthday);
            Controls.Add(Lbl_Email);
            Controls.Add(Txt_Email);
            Controls.Add(Lbl_Name);
            Controls.Add(Txt_Name);
            Name = "Frm_Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Name;
        private TextBox Txt_Name;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_Birthday;
        private DateTimePicker DateTimePicker_Birthday;
        private Label Lbl_User;
        private TextBox Txt_User;
        private Label Lbl_Password;
        private TextBox Txt_Password;
        private Label Lbl_ConfirmPassword;
        private TextBox Txt_ConfirmPassword;
        private Button Btn_Register;
    }
}