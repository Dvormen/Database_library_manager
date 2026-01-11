namespace DBBooks.Forms.Genre
{
    partial class GenreDeleteForm
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
            textBox_id.Location = new Point(117, 116);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "Genre id";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 5;
            // 
            // button_back
            // 
            button_back.Location = new Point(262, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 4;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(131, 145);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // GenreDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 252);
            Controls.Add(textBox_id);
            Controls.Add(button_back);
            Controls.Add(button_delete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GenreDeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Genre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private Button button_back;
        private Button button_delete;
    }
}