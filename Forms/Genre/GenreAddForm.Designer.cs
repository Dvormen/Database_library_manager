namespace DBBooks.Forms.Genre
{
    partial class GenreAddForm
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
            button_import = new Button();
            textBox_genre = new TextBox();
            button_back = new Button();
            button_add = new Button();
            SuspendLayout();
            // 
            // button_import
            // 
            button_import.Location = new Point(112, 199);
            button_import.Name = "button_import";
            button_import.Size = new Size(75, 23);
            button_import.TabIndex = 9;
            button_import.Text = "Import";
            button_import.UseVisualStyleBackColor = true;
            button_import.Click += button_import_Click;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(98, 113);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.PlaceholderText = "Genre";
            textBox_genre.Size = new Size(100, 23);
            textBox_genre.TabIndex = 7;
            // 
            // button_back
            // 
            button_back.Location = new Point(241, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 6;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(112, 142);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 5;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // GenreAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 257);
            Controls.Add(button_import);
            Controls.Add(textBox_genre);
            Controls.Add(button_back);
            Controls.Add(button_add);
            Name = "GenreAddForm";
            Text = "Genre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_import;
        private TextBox textBox_genre;
        private Button button_back;
        private Button button_add;
    }
}