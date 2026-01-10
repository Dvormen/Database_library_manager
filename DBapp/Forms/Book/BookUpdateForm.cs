using DBBooks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBBooks.Forms.Book
{
    public partial class BookUpdateForm : Form
    {
        public BookUpdateForm()
        {
            InitializeComponent();
            comboBox_state.DataSource = Enum.GetValues(typeof(State));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int book_id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            var book = new Tables.Book { Book_id = book_id };

            if (!string.IsNullOrWhiteSpace(textBox_title.Text))
            {
                book.BookTitle = textBox_title.Text;
            }

            if (int.TryParse(textBox_author.Text, out int author_id))
            {
                book.Author_id = author_id;
            }

            if (int.TryParse(textBox_genre.Text, out int genre_id))
            {
                book.Genre_id = genre_id;
            }

            if (decimal.TryParse(textBox_price.Text, out decimal price))
            {
                book.Price = price;
            }

            book.Available = checkBox_available.CheckState == CheckState.Checked ? true : (bool?)null;

            if (comboBox_state.SelectedItem != null)
            {
                book.State = (State)comboBox_state.SelectedItem;
            }

            var repo = new BookRepository();
            repo.Update(book);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
