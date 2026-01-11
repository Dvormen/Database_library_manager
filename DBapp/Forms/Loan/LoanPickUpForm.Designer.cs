namespace DBBooks.Forms.Loan
{
    partial class LoanPickUpForm
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
            dataGridView_user = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            UsernameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            dataGridView_books = new DataGridView();
            IdColumnBooks = new DataGridViewTextBoxColumn();
            TitleColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            AvailableColumn = new DataGridViewTextBoxColumn();
            StateColumn = new DataGridViewTextBoxColumn();
            GenreColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            textBox_user_id = new TextBox();
            textBox_book_id = new TextBox();
            button_pickUp = new Button();
            button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_user
            // 
            dataGridView_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_user.Columns.AddRange(new DataGridViewColumn[] { IdColumn, UsernameColumn, EmailColumn });
            dataGridView_user.Location = new Point(12, 12);
            dataGridView_user.Name = "dataGridView_user";
            dataGridView_user.ReadOnly = true;
            dataGridView_user.Size = new Size(418, 342);
            dataGridView_user.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "User_id";
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // UsernameColumn
            // 
            UsernameColumn.DataPropertyName = "Username";
            UsernameColumn.HeaderText = "Username";
            UsernameColumn.Name = "UsernameColumn";
            UsernameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            EmailColumn.DataPropertyName = "Email";
            EmailColumn.HeaderText = "Email";
            EmailColumn.Name = "EmailColumn";
            EmailColumn.ReadOnly = true;
            // 
            // dataGridView_books
            // 
            dataGridView_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_books.Columns.AddRange(new DataGridViewColumn[] { IdColumnBooks, TitleColumn, PriceColumn, AvailableColumn, StateColumn, GenreColumn, AuthorColumn });
            dataGridView_books.Location = new Point(436, 12);
            dataGridView_books.Name = "dataGridView_books";
            dataGridView_books.ReadOnly = true;
            dataGridView_books.Size = new Size(807, 342);
            dataGridView_books.TabIndex = 1;
            // 
            // IdColumnBooks
            // 
            IdColumnBooks.DataPropertyName = "Book_id";
            IdColumnBooks.HeaderText = "ID";
            IdColumnBooks.Name = "IdColumnBooks";
            IdColumnBooks.ReadOnly = true;
            // 
            // TitleColumn
            // 
            TitleColumn.DataPropertyName = "BookTitle";
            TitleColumn.HeaderText = "Title";
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.DataPropertyName = "Price";
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // AvailableColumn
            // 
            AvailableColumn.DataPropertyName = "Available";
            AvailableColumn.HeaderText = "Available";
            AvailableColumn.Name = "AvailableColumn";
            AvailableColumn.ReadOnly = true;
            // 
            // StateColumn
            // 
            StateColumn.DataPropertyName = "State";
            StateColumn.HeaderText = "State";
            StateColumn.Name = "StateColumn";
            StateColumn.ReadOnly = true;
            // 
            // GenreColumn
            // 
            GenreColumn.DataPropertyName = "Genre_id";
            GenreColumn.HeaderText = "Genre ID";
            GenreColumn.Name = "GenreColumn";
            GenreColumn.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            AuthorColumn.DataPropertyName = "Author_id";
            AuthorColumn.HeaderText = "Author ID";
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.ReadOnly = true;
            // 
            // textBox_user_id
            // 
            textBox_user_id.Location = new Point(76, 394);
            textBox_user_id.Name = "textBox_user_id";
            textBox_user_id.PlaceholderText = "User ID";
            textBox_user_id.Size = new Size(100, 23);
            textBox_user_id.TabIndex = 2;
            // 
            // textBox_book_id
            // 
            textBox_book_id.Location = new Point(227, 394);
            textBox_book_id.Name = "textBox_book_id";
            textBox_book_id.PlaceholderText = "Book ID";
            textBox_book_id.Size = new Size(100, 23);
            textBox_book_id.TabIndex = 3;
            // 
            // button_pickUp
            // 
            button_pickUp.Location = new Point(375, 394);
            button_pickUp.Name = "button_pickUp";
            button_pickUp.Size = new Size(75, 23);
            button_pickUp.TabIndex = 4;
            button_pickUp.Text = "Pick Up";
            button_pickUp.UseVisualStyleBackColor = true;
            button_pickUp.Click += button_pickUp_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(491, 394);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 5;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // LoanPickUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 450);
            Controls.Add(button_back);
            Controls.Add(button_pickUp);
            Controls.Add(textBox_book_id);
            Controls.Add(textBox_user_id);
            Controls.Add(dataGridView_books);
            Controls.Add(dataGridView_user);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoanPickUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan";
            Load += LoanPickUp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_user;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private DataGridView dataGridView_books;
        private TextBox textBox_user_id;
        private TextBox textBox_book_id;
        private Button button_pickUp;
        private Button button_back;
        private DataGridViewTextBoxColumn IdColumnBooks;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn AvailableColumn;
        private DataGridViewTextBoxColumn StateColumn;
        private DataGridViewTextBoxColumn GenreColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
    }
}