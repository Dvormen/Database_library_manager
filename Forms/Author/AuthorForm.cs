using DBBooks.Data;
using DBBooks.Forms.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBBooks.Forms.Author
{
    public partial class AuthorForm : Form
    {
        private AuthorRepository repository;
        public AuthorForm()
        {
            InitializeComponent();
            repository = new AuthorRepository();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = repository.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading authors " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AuthorAddForm aaForm = new AuthorAddForm();
            if (aaForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            AuthorUpdateForm auForm = new AuthorUpdateForm();
            if (auForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Author adForm = new Author();
            if (adForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var repo = new AuthorRepository();
            dataGridView1.DataSource = repo.GetAll();
        }
    }
}
