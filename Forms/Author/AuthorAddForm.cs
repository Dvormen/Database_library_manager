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

namespace DBBooks.Forms.Author
{
    public partial class AuthorAddForm : Form
    {
        public AuthorAddForm()
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
                var author = new Tables.Author
                {
                    FirstName = textBox_firstName.Text,
                    LastName = textBox_lastName.Text
                };

                var repo = new AuthorRepository();
                repo.Add(author);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with adding author: " + ex.Message);
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            var filePath = CsvDialog();

            if (filePath == null)
                return;

            try
            {
                var repo = new AuthorRepository();
                repo.CsvImportAuthors(filePath);

                MessageBox.Show("Authors imported successfully!");
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
                dialog.Title = "Select a CSV file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }

                return null;
            }
        }
    }
}
