namespace DBBooks.Forms.Book
{
    partial class BookAddForm
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
            textBox_title = new TextBox();
            textBox_price = new TextBox();
            textBox_genre = new TextBox();
            textBox_author = new TextBox();
            comboBox_state = new ComboBox();
            button_add = new Button();
            checkBox_available = new CheckBox();
            button_back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(12, 25);
            textBox_title.Name = "textBox_title";
            textBox_title.PlaceholderText = "Title";
            textBox_title.Size = new Size(100, 23);
            textBox_title.TabIndex = 0;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(133, 64);
            textBox_price.Name = "textBox_price";
            textBox_price.PlaceholderText = "Price";
            textBox_price.Size = new Size(100, 23);
            textBox_price.TabIndex = 1;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(12, 64);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.PlaceholderText = "Genre";
            textBox_genre.Size = new Size(100, 23);
            textBox_genre.TabIndex = 2;
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(133, 25);
            textBox_author.Name = "textBox_author";
            textBox_author.PlaceholderText = "Authors id";
            textBox_author.Size = new Size(100, 23);
            textBox_author.TabIndex = 3;
            // 
            // comboBox_state
            // 
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Location = new Point(12, 130);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new Size(121, 23);
            comboBox_state.TabIndex = 4;
            // 
            // button_add
            // 
            button_add.Location = new Point(87, 202);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 5;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // checkBox_available
            // 
            checkBox_available.AutoSize = true;
            checkBox_available.Location = new Point(151, 132);
            checkBox_available.Name = "checkBox_available";
            checkBox_available.Size = new Size(79, 19);
            checkBox_available.TabIndex = 6;
            checkBox_available.Text = "Available?";
            checkBox_available.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Location = new Point(282, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 7;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 112);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "State";
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 253);
            Controls.Add(label1);
            Controls.Add(button_back);
            Controls.Add(checkBox_available);
            Controls.Add(button_add);
            Controls.Add(comboBox_state);
            Controls.Add(textBox_author);
            Controls.Add(textBox_genre);
            Controls.Add(textBox_price);
            Controls.Add(textBox_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_title;
        private TextBox textBox_price;
        private TextBox textBox_genre;
        private TextBox textBox_author;
        private ComboBox comboBox_state;
        private Button button_add;
        private CheckBox checkBox_available;
        private Button button_back;
        private Label label1;
    }
}