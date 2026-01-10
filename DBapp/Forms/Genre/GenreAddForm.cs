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

namespace DBBooks.Forms.Genre
{
    public partial class GenreAddForm : Form
    {
        public GenreAddForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var genre = new Tables.Genre
                {
                    GenreName = textBox_genre.Text
                };

                var repo = new GenreRepository();
                repo.Add(genre);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error with adding genre: " + exception.Message);
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            var filePath = CsvDialog();

            if (filePath == null)
                return;

            try
            {
                var repo = new GenreRepository();
                repo.CsvImportGenre(filePath);

                MessageBox.Show("Genres were imported successfully");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        private string? CsvDialog()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.Title = "Select CSV file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }

                return null;
            }
        }
    }
}
