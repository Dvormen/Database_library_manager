namespace DBBooks.Forms.User
{
    partial class UserDeleteForm
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
            button_back = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(104, 116);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "User id";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 8;
            // 
            // button_back
            // 
            button_back.Location = new Point(249, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 7;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(118, 145);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 6;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // UserDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 228);
            Controls.Add(textBox_id);
            Controls.Add(button_back);
            Controls.Add(button_delete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserDeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private Button button_back;
        private Button button_delete;
    }
}