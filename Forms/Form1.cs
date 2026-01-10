using DBBooks.Forms.Author;
using DBBooks.Forms.Book;
using DBBooks.Forms.Genre;
using DBBooks.Forms.Loan;
using DBBooks.Forms.Reports;
using DBBooks.Forms.User;

namespace DBBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void author_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void book_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookForm booksForm = new BookForm();
            booksForm.ShowDialog();
        }

        private void genre_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenreForm genreForm = new GenreForm();
            genreForm.ShowDialog();
        }

        private void user_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void loan_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoanForm loanForm = new LoanForm();
            loanForm.ShowDialog();

        }

        private void Breport_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookReportForm brForm = new BookReportForm();
            brForm.ShowDialog();
        }

        private void Areport_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorReportForm arForm = new AuthorReportForm();
            arForm.ShowDialog();
        }
    }
}
