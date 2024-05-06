namespace Oyrennme_AdoNet
{
    partial class Login
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
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            registerHref = new LinkLabel();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(272, 57);
            username.Name = "username";
            username.Size = new Size(210, 27);
            username.TabIndex = 0;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(272, 135);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(210, 27);
            password.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(272, 225);
            button1.Name = "button1";
            button1.Size = new Size(210, 78);
            button1.TabIndex = 2;
            button1.Text = "Daxil ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // registerHref
            // 
            registerHref.AutoSize = true;
            registerHref.Location = new Point(327, 334);
            registerHref.Name = "registerHref";
            registerHref.Size = new Size(126, 20);
            registerHref.TabIndex = 3;
            registerHref.TabStop = true;
            registerHref.Text = "Qeydiyyatdan keç";
            registerHref.LinkClicked += registerHref_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerHref);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button button1;
        private LinkLabel registerHref;
    }
}