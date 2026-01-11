namespace DBBooks.Forms.Author
{
    partial class Author
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
            button_delete = new Button();
            button_back = new Button();
            textBox_Id = new TextBox();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.Location = new Point(141, 173);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 0;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(269, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 1;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_Id
            // 
            textBox_Id.Location = new Point(129, 124);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.PlaceholderText = "Author id";
            textBox_Id.Size = new Size(100, 23);
            textBox_Id.TabIndex = 2;
            // 
            // Author
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 235);
            Controls.Add(textBox_Id);
            Controls.Add(button_back);
            Controls.Add(button_delete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Author";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_delete;
        private Button button_back;
        private TextBox textBox_Id;
    }
}