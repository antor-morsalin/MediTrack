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
    public partial class AccountDetailsForm : Form
    {
        Form prev;
        User user;
        public AccountDetailsForm(Form prev, User user)
        {
            InitializeComponent();
            this.prev = prev;
            this.user = user;
            this.NameTb.Text = user.Full_name;
            this.Username.Text = user.User_name;
            this.Password.Text = user.Password;
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DetailsBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }
    }
}
