namespace DBBooks.Forms.User
{
    partial class UserUpdateForm
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
            button_back = new Button();
            button_update = new Button();
            textBox_username = new TextBox();
            textBox_id = new TextBox();
            textBox_email = new TextBox();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Location = new Point(258, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 13;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(120, 188);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 12;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(46, 145);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "New Username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 11;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(97, 102);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "Id of updated user";
            textBox_id.Size = new Size(125, 23);
            textBox_id.TabIndex = 10;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(178, 145);
            textBox_email.Name = "textBox_email";
            textBox_email.PlaceholderText = "New Email";
            textBox_email.Size = new Size(100, 23);
            textBox_email.TabIndex = 14;
            // 
            // UserUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 255);
            Controls.Add(textBox_email);
            Controls.Add(button_back);
            Controls.Add(button_update);
            Controls.Add(textBox_username);
            Controls.Add(textBox_id);
            Name = "UserUpdateForm";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private Button button_update;
        private TextBox textBox_username;
        private TextBox textBox_id;
        private TextBox textBox_email;
    }
}