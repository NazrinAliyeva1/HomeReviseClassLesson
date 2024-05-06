namespace Oyrennme_AdoNet
{
    partial class Register
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
            button1 = new Button();
            name = new TextBox();
            surname = new TextBox();
            username = new TextBox();
            password = new TextBox();
            gender = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(186, 245);
            button1.Name = "button1";
            button1.Size = new Size(241, 91);
            button1.TabIndex = 0;
            button1.Text = "Qeydiyyatdan keç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Location = new Point(212, 66);
            name.Name = "name";
            name.Size = new Size(198, 27);
            name.TabIndex = 1;
            // 
            // surname
            // 
            surname.Location = new Point(212, 99);
            surname.Name = "surname";
            surname.Size = new Size(198, 27);
            surname.TabIndex = 2;
            // 
            // username
            // 
            username.Location = new Point(212, 165);
            username.Name = "username";
            username.Size = new Size(198, 27);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(212, 198);
            password.Name = "password";
            password.Size = new Size(198, 27);
            password.TabIndex = 4;
            // 
            // gender
            // 
            gender.Location = new Point(212, 132);
            gender.Name = "gender";
            gender.Size = new Size(198, 27);
            gender.TabIndex = 5;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(gender);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(button1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox name;
        private TextBox surname;
        private TextBox username;
        private TextBox password;
        private TextBox gender;
    }
}