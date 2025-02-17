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
    public partial class SettingsForm : Form
    {
        Form prev;
        User user;
        public SettingsForm(Form prev, User user)
        {
            this.prev = prev;
            this.user = user;

            InitializeComponent();
            SettingsBackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            SettingsBackBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            SettingsAccountDetailsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 161, 158);
            SettingsAccountDetailsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);

            SettingsUpdateDetailsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 161, 158);
            SettingsUpdateDetailsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);

            SettingsDeleteAccountBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 161, 158);
            SettingsDeleteAccountBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);

            SettingsTermsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 161, 158);
            SettingsTermsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void SettingsAccountDetailsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountDetailsForm(this, user).Show();
        }

        private void SettingsUpdateDetailsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateAccountDetailsForm(this, user).Show();
        }

        private void SettingsTermsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PolicyTermsForm(this).Show();
        }

        private void SettingsDeleteAccountBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact the developer team to remove user account and all its information permanently from the system",
                "Action Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
