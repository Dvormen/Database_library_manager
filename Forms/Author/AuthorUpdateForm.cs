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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBBooks.Forms.Author
{
    public partial class AuthorUpdateForm : Form
    {
        public AuthorUpdateForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int authorId))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            var author = new Tables.Author { Author_id = authorId };

            if (!string.IsNullOrWhiteSpace(textBox_firstName.Text))
            {
                author.FirstName = textBox_firstName.Text;
            }

            if (!string.IsNullOrWhiteSpace(textBox_lastName.Text))
            {
                author.LastName = textBox_lastName.Text;
            }

            var repo = new AuthorRepository();
            repo.Update(author);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
