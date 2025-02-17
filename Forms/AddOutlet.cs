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
    public partial class AddOutletForm : Form
    {
        Form prev;
        User user;
        public AddOutletForm(Form prev, User user)
        {
            InitializeComponent();
            AddOutletBackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            AddOutletBackBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);
            this.prev = prev;
            this.user = user;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOutletForm_Load(object sender, EventArgs e)
        {

        }

        private void AddOutletBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            prev.Show();
        }

        private void AddOutletBtn_Click(object sender, EventArgs e)
        {
            string outlet_name = OutletNameTb.Text.Trim();
            string outlet_address = OutletAddressTb.Text.Trim();
            string outlet_contact = OutletContactTb.Text.Trim();

            if(!Authorization.firstNameAuth(outlet_name))
            {
                MessageBox.Show("Outlet name must be 3 characters or more", "Invalid outlet name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Authorization.firstNameAuth(outlet_address))
            {
                MessageBox.Show("Outlet address must be 3 characters or more", "Invalid outlet address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Authorization.contactAuth(outlet_contact))
            {
                MessageBox.Show("Entered contact information is not correct", "Invalid contact information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int user_id = DatabaseConnection.get_userId(user.User_name);

                string query = "INSERT INTO Outlet (user_id, outlet_name, outlet_address, outlet_contact) VALUES ("+user_id+ ", '"+outlet_name+ "', '"+outlet_address+ "', '"+outlet_contact+"');";

                DatabaseConnection.ExecuteQuery(query);

                MessageBox.Show("Outlet added successfully", "Outlet added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                prev.Show();
            }
        }
    }
}
