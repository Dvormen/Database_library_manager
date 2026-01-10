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

namespace DBBooks.Forms.User
{
    public partial class UserDeleteForm : Form
    {
        public UserDeleteForm()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int user_id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            var repo = new UserRepository();
            repo.Delete(user_id);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
