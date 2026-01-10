namespace DBBooks.Forms.Genre
{
    partial class GenreUpdateForm
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
            textBox_genre = new TextBox();
            textBox_id = new TextBox();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Location = new Point(247, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 9;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(109, 188);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 8;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(99, 143);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.PlaceholderText = "New Genre";
            textBox_genre.Size = new Size(100, 23);
            textBox_genre.TabIndex = 7;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(86, 102);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "Id of updated genre";
            textBox_id.Size = new Size(125, 23);
            textBox_id.TabIndex = 5;
            // 
            // GenreUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 234);
            Controls.Add(button_back);
            Controls.Add(button_update);
            Controls.Add(textBox_genre);
            Controls.Add(textBox_id);
            Name = "GenreUpdateForm";
            Text = "Genre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private Button button_update;
        private TextBox textBox_genre;
        private TextBox textBox_id;
    }
}