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

namespace DBBooks.Forms.Book
{
    public partial class BookForm : Form
    {
        private BookRepository repository;
        public BookForm()
        {
            InitializeComponent();
            repository = new BookRepository();
        }
        private void BookForm_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error with loading books " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var baForm = new BookAddForm();
            if (baForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var buForm = new BookUpdateForm();
            if (buForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var bdForm = new BookDeleteForm();
            if (bdForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var repo = new BookRepository();
            dataGridView1.DataSource = repo.GetAll();
        }
    }
}
