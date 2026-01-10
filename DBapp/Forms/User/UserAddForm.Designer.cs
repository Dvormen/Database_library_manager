namespace DBBooks.Forms.User
{
    partial class UserAddForm
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
            textBox_email = new TextBox();
            textBox_username = new TextBox();
            button_back = new Button();
            button_add = new Button();
            SuspendLayout();
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(181, 113);
            textBox_email.Name = "textBox_email";
            textBox_email.PlaceholderText = "Email";
            textBox_email.Size = new Size(100, 23);
            textBox_email.TabIndex = 8;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(42, 113);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 7;
            // 
            // button_back
            // 
            button_back.Location = new Point(252, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 6;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(122, 155);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 5;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // UserAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 255);
            Controls.Add(textBox_email);
            Controls.Add(textBox_username);
            Controls.Add(button_back);
            Controls.Add(button_add);
            Name = "UserAddForm";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_email;
        private TextBox textBox_username;
        private Button button_back;
        private Button button_add;
    }
}