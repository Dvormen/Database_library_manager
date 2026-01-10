using DBBooks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBBooks.Forms.Loan
{
    public partial class LoanPickUpForm : Form
    {
        private UserRepository userRepository;
        private BookRepository bookRepository;
        public LoanPickUpForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            bookRepository = new BookRepository();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView_user.DataSource = userRepository.GetAll();
                dataGridView_books.DataSource = bookRepository.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading loans " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoanPickUp_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button_pickUp_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_book_id.Text, out int book_id) || !int.TryParse(textBox_user_id.Text, out int member_id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            try
            {
                var repo = new LoanRepository();
                repo.BorrowBook(book_id, member_id);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with picking up: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
