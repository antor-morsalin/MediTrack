using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrackForms
{
    public partial class LoginForm : Form
    {
        Form prev;
        public LoginForm(Form prev)
        {
            this.prev = prev;
            InitializeComponent();
            LoginBackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            LoginBackBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);
        }

        private void LoginLoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.LoginUsernameTb.Text.Trim();
            string password = this.LoginPasswordTb.Text.Trim();
            if (!Authorization.passwordAuth(username, password))
            {
                MessageBox.Show("Enter valid username and password", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string full_name = DatabaseConnection.GetFullName(username);
                new HomeForm(new User(full_name, username, password), prev).Show();
                this.Close();
            }
        }

        private void LoginBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
