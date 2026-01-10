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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBBooks.Forms.Book
{
    public partial class BookDeleteForm : Form
    {
        public BookDeleteForm()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int book_id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            var repo = new BookRepository();
            repo.Delete(book_id);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
