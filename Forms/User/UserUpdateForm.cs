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

namespace DBBooks.Forms.User
{
    public partial class UserUpdateForm : Form
    {
        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int user_id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            var user = new Tables.User { User_id = user_id };

            if (!string.IsNullOrWhiteSpace(textBox_username.Text))
            {
                user.Username = textBox_username.Text;
            }

            if (!string.IsNullOrWhiteSpace(textBox_email.Text))
            {
                user.Email = textBox_email.Text;
            }

            var repo = new UserRepository();
            repo.Update(user);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
