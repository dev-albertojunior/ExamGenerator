namespace ExamGenerator.GUI.Forms
{
    partial class Frm_Login
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
            Txt_User = new TextBox();
            Txt_Password = new TextBox();
            Lbl_User = new Label();
            Lbl_Password = new Label();
            LinkLbl_ForgotPassword = new LinkLabel();
            Btn_Register = new Button();
            Btn_LogIn = new Button();
            SuspendLayout();
            // 
            // Txt_User
            // 
            Txt_User.Location = new Point(28, 40);
            Txt_User.Name = "Txt_User";
            Txt_User.Size = new Size(149, 23);
            Txt_User.TabIndex = 0;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(183, 40);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '*';
            Txt_Password.Size = new Size(149, 23);
            Txt_Password.TabIndex = 1;
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_User
            // 
            Lbl_User.AutoSize = true;
            Lbl_User.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_User.Location = new Point(28, 22);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(33, 15);
            Lbl_User.TabIndex = 2;
            Lbl_User.Text = "User";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Password.Location = new Point(183, 22);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(59, 15);
            Lbl_Password.TabIndex = 3;
            Lbl_Password.Text = "Password";
            // 
            // LinkLbl_ForgotPassword
            // 
            LinkLbl_ForgotPassword.AutoSize = true;
            LinkLbl_ForgotPassword.Location = new Point(232, 66);
            LinkLbl_ForgotPassword.Name = "LinkLbl_ForgotPassword";
            LinkLbl_ForgotPassword.Size = new Size(100, 15);
            LinkLbl_ForgotPassword.TabIndex = 4;
            LinkLbl_ForgotPassword.TabStop = true;
            LinkLbl_ForgotPassword.Text = "Forgot Password?";
            // 
            // Btn_Register
            // 
            Btn_Register.Location = new Point(183, 103);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(149, 26);
            Btn_Register.TabIndex = 5;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = true;
            // 
            // Btn_LogIn
            // 
            Btn_LogIn.Location = new Point(28, 103);
            Btn_LogIn.Name = "Btn_LogIn";
            Btn_LogIn.Size = new Size(149, 26);
            Btn_LogIn.TabIndex = 6;
            Btn_LogIn.Text = "Log In";
            Btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(363, 151);
            Controls.Add(Btn_LogIn);
            Controls.Add(Btn_Register);
            Controls.Add(LinkLbl_ForgotPassword);
            Controls.Add(Lbl_Password);
            Controls.Add(Lbl_User);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_User);
            Name = "Frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Txt_Password;
        private Label Lbl_User;
        private Label Lbl_Password;
        private LinkLabel LinkLbl_ForgotPassword;
        private Button Btn_Register;
        private Button Btn_LogIn;
        private TextBox Txt_User;
    }
}