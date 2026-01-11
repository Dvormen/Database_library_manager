namespace DBBooks.Forms.Author
{
    partial class AuthorUpdateForm
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
            textBox_id = new TextBox();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            button_update = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(112, 102);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "Id of updated author";
            textBox_id.Size = new Size(125, 23);
            textBox_id.TabIndex = 0;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(43, 143);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.PlaceholderText = "New First Name";
            textBox_firstName.Size = new Size(100, 23);
            textBox_firstName.TabIndex = 1;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(207, 143);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.PlaceholderText = "New Last Name";
            textBox_lastName.Size = new Size(100, 23);
            textBox_lastName.TabIndex = 2;
            // 
            // button_update
            // 
            button_update.Location = new Point(135, 188);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 3;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(273, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 4;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // AuthorUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(button_back);
            Controls.Add(button_update);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_id);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthorUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Button button_update;
        private Button button_back;
    }
}