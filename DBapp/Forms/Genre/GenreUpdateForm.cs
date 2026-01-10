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

namespace DBBooks.Forms.Genre
{
    public partial class GenreUpdateForm : Form
    {
        public GenreUpdateForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int genre_id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            var genre = new Tables.Genre { Genre_id = genre_id };

            if (!string.IsNullOrWhiteSpace(textBox_genre.Text))
            {
                genre.GenreName = textBox_genre.Text;
            }

            var repo = new GenreRepository();
            repo.Update(genre);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
