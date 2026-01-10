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

namespace DBBooks.Forms.Author
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_Id.Text, out int author_id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            var repo = new AuthorRepository();
            repo.Delete(author_id);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
