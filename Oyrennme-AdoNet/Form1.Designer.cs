namespace Oyrennme_AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            nameInput = new TextBox();
            surnameInput = new TextBox();
            radioButton1 = new RadioButton();
            Qadın = new RadioButton();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(528, 50);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(759, 466);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 59);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(183, 27);
            nameInput.TabIndex = 1;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(201, 59);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(167, 27);
            surnameInput.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(374, 62);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kişi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Qadın
            // 
            Qadın.AutoSize = true;
            Qadın.Location = new Point(433, 62);
            Qadın.Name = "Qadın";
            Qadın.Size = new Size(70, 24);
            Qadın.TabIndex = 4;
            Qadın.Text = "Qadin";
            Qadın.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(658, 48);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(130, 38);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 605);
            Controls.Add(deleteBtn);
            Controls.Add(Qadın);
            Controls.Add(radioButton1);
            Controls.Add(surnameInput);
            Controls.Add(nameInput);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox nameInput;
        private TextBox surnameInput;
        private RadioButton radioButton1;
        private RadioButton Qadın;
        private Button deleteBtn;
    }
}
