namespace DBBooks.Forms.Book
{
    partial class BookUpdateForm
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
            label1 = new Label();
            button_back = new Button();
            checkBox_available = new CheckBox();
            button_update = new Button();
            comboBox_state = new ComboBox();
            textBox_author = new TextBox();
            textBox_genre = new TextBox();
            textBox_price = new TextBox();
            textBox_title = new TextBox();
            textBox_id = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 129);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 17;
            label1.Text = "State";
            // 
            // button_back
            // 
            button_back.Location = new Point(301, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 16;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // checkBox_available
            // 
            checkBox_available.AutoSize = true;
            checkBox_available.Location = new Point(169, 149);
            checkBox_available.Name = "checkBox_available";
            checkBox_available.Size = new Size(79, 19);
            checkBox_available.TabIndex = 15;
            checkBox_available.Text = "Available?";
            checkBox_available.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            button_update.Location = new Point(106, 202);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 14;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // comboBox_state
            // 
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Location = new Point(30, 147);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new Size(121, 23);
            comboBox_state.TabIndex = 13;
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(148, 63);
            textBox_author.Name = "textBox_author";
            textBox_author.PlaceholderText = "Authors id";
            textBox_author.Size = new Size(100, 23);
            textBox_author.TabIndex = 12;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(30, 92);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.PlaceholderText = "Genre";
            textBox_genre.Size = new Size(100, 23);
            textBox_genre.TabIndex = 11;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(148, 92);
            textBox_price.Name = "textBox_price";
            textBox_price.PlaceholderText = "Price";
            textBox_price.Size = new Size(100, 23);
            textBox_price.TabIndex = 10;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(30, 63);
            textBox_title.Name = "textBox_title";
            textBox_title.PlaceholderText = "Title";
            textBox_title.Size = new Size(100, 23);
            textBox_title.TabIndex = 9;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(81, 29);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "Id of updated book";
            textBox_id.Size = new Size(111, 23);
            textBox_id.TabIndex = 18;
            // 
            // BookUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 240);
            Controls.Add(textBox_id);
            Controls.Add(label1);
            Controls.Add(button_back);
            Controls.Add(checkBox_available);
            Controls.Add(button_update);
            Controls.Add(comboBox_state);
            Controls.Add(textBox_author);
            Controls.Add(textBox_genre);
            Controls.Add(textBox_price);
            Controls.Add(textBox_title);
            Name = "BookUpdateForm";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_back;
        private CheckBox checkBox_available;
        private Button button_update;
        private ComboBox comboBox_state;
        private TextBox textBox_author;
        private TextBox textBox_genre;
        private TextBox textBox_price;
        private TextBox textBox_title;
        private TextBox textBox_id;
    }
}