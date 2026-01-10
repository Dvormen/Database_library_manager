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

namespace DBBooks.Forms.Book
{
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
            comboBox_state.DataSource = Enum.GetValues(typeof(State));
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new Tables.Book
                {
                    BookTitle = textBox_title.Text,
                    Price = decimal.Parse(textBox_price.Text),
                    Available = checkBox_available.Checked,
                    State = (State)comboBox_state.SelectedItem,
                    Author_id = int.Parse(textBox_author.Text),
                    Genre_id = int.Parse(textBox_genre.Text)
                };

                var repo = new BookRepository();
                repo.Add(book);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error adding book: " + exception.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
