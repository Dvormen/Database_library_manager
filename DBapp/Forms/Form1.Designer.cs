namespace DBBooks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            author_link = new LinkLabel();
            book_link = new LinkLabel();
            genre_link = new LinkLabel();
            user_link = new LinkLabel();
            loan_link = new LinkLabel();
            Breport_link = new LinkLabel();
            Areport_link = new LinkLabel();
            SuspendLayout();
            // 
            // author_link
            // 
            author_link.AutoSize = true;
            author_link.LinkColor = Color.Black;
            author_link.Location = new Point(74, 9);
            author_link.Name = "author_link";
            author_link.Size = new Size(49, 15);
            author_link.TabIndex = 0;
            author_link.TabStop = true;
            author_link.Text = "Authors";
            author_link.LinkClicked += author_link_LinkClicked;
            // 
            // book_link
            // 
            book_link.AutoSize = true;
            book_link.LinkColor = Color.Black;
            book_link.Location = new Point(78, 34);
            book_link.Name = "book_link";
            book_link.Size = new Size(39, 15);
            book_link.TabIndex = 1;
            book_link.TabStop = true;
            book_link.Text = "Books";
            book_link.LinkClicked += book_link_LinkClicked;
            // 
            // genre_link
            // 
            genre_link.AutoSize = true;
            genre_link.LinkColor = Color.Black;
            genre_link.Location = new Point(78, 59);
            genre_link.Name = "genre_link";
            genre_link.Size = new Size(43, 15);
            genre_link.TabIndex = 2;
            genre_link.TabStop = true;
            genre_link.Text = "Genres";
            genre_link.LinkClicked += genre_link_LinkClicked;
            // 
            // user_link
            // 
            user_link.AutoSize = true;
            user_link.LinkColor = Color.Black;
            user_link.Location = new Point(78, 85);
            user_link.Name = "user_link";
            user_link.Size = new Size(35, 15);
            user_link.TabIndex = 3;
            user_link.TabStop = true;
            user_link.Text = "Users";
            user_link.LinkClicked += user_link_LinkClicked;
            // 
            // loan_link
            // 
            loan_link.AutoSize = true;
            loan_link.LinkColor = Color.Black;
            loan_link.Location = new Point(75, 113);
            loan_link.Name = "loan_link";
            loan_link.Size = new Size(38, 15);
            loan_link.TabIndex = 4;
            loan_link.TabStop = true;
            loan_link.Text = "Loans";
            loan_link.LinkClicked += loan_link_LinkClicked;
            // 
            // Breport_link
            // 
            Breport_link.AutoSize = true;
            Breport_link.LinkColor = Color.Black;
            Breport_link.Location = new Point(56, 138);
            Breport_link.Name = "Breport_link";
            Breport_link.Size = new Size(77, 15);
            Breport_link.TabIndex = 5;
            Breport_link.TabStop = true;
            Breport_link.Text = "Book Reports";
            Breport_link.LinkClicked += Breport_link_LinkClicked;
            // 
            // Areport_link
            // 
            Areport_link.AutoSize = true;
            Areport_link.LinkColor = Color.Black;
            Areport_link.Location = new Point(46, 164);
            Areport_link.Name = "Areport_link";
            Areport_link.Size = new Size(87, 15);
            Areport_link.TabIndex = 6;
            Areport_link.TabStop = true;
            Areport_link.Text = "Author Reports";
            Areport_link.LinkClicked += Areport_link_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 224);
            Controls.Add(Areport_link);
            Controls.Add(Breport_link);
            Controls.Add(loan_link);
            Controls.Add(user_link);
            Controls.Add(genre_link);
            Controls.Add(book_link);
            Controls.Add(author_link);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel author_link;
        private LinkLabel book_link;
        private LinkLabel genre_link;
        private LinkLabel user_link;
        private LinkLabel loan_link;
        private LinkLabel Breport_link;
        private LinkLabel Areport_link;
    }
}
