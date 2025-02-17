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
    public partial class EditOutletDetailsForm : Form
    {
        Form prev_prev;
        Form prev;
        Outlet outlet;
        public EditOutletDetailsForm(Form prev_prev, Form prev, Outlet outlet)
        {
            InitializeComponent();
            this.prev_prev = prev_prev;
            this.prev = prev;
            this.outlet = outlet;
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            nameTb.Text = outlet.Outlet_name;
            addressTb.Text = outlet.Outlet_address;
            contactTb.Text = outlet.Outlet_contact;
        }

        private void EditOutletDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            string newName = nameTb.Text;
            string newAddress = addressTb.Text;
            string newContact = contactTb.Text;
            if (!Authorization.firstNameAuth(newName))
            {
                MessageBox.Show("Outlet name must be 3 characters or more", "Invalid outlet name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Authorization.firstNameAuth(newAddress))
            {
                MessageBox.Show("Outlet address must be 3 characters or more", "Invalid outlet address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Authorization.contactAuth(newContact))
            {
                MessageBox.Show("Entered contact information is not correct", "Invalid contact information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatabaseConnection.updateOutletDetails(outlet.Outlet_id, newName, newAddress, newContact);
                MessageBox.Show("Details updated successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                prev.Close();
                prev_prev.Show();
            }
        }
    }
}
