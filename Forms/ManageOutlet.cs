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
    public partial class ManageOutletForm : Form
    {
        Form prev; User user;

        public ManageOutletForm(Form prev, User user)
        {

            InitializeComponent();

            this.prev = prev;
            this.user = user;

            back.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            back.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);


            List<Outlet> outletList = new List<Outlet>();
            outletList = DatabaseConnection.getOutlets(user.User_name);

            tlp.RowCount = outletList.Count;

            foreach (RowStyle row in tlp.RowStyles)
            {
                row.SizeType = SizeType.Absolute;
                row.Height = 60; 
            }


            for (int i = 0; i < outletList.Count; i++)
            {

                Outlet outlet = outletList[i];

                Label nameLabel = new Label
                {
                    Text = outlet.Outlet_name,
                    Font = new Font("MS Reference Sans Serif", 14),
                    Margin = new Padding(5),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill
                };
                Button detailsButton = new Button
                {
                    Text = "Outlet Details",
                    Tag = outlet,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                    
                };
                detailsButton.Click += OutletDetails_Click;

                Button editDetailsButton = new Button
                {
                    Text = "Edit Details",
                    Tag = outlet,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                    
                };
                editDetailsButton.Click += editDetailsButton_Click;

                Button removeButton = new Button
                {
                    Text = "Remove Outlet",
                    Tag = outlet,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                    
                };
                removeButton.Click += RemoveOutlet_Click;

                tlp.Controls.Add(nameLabel, 0, i);
                tlp.Controls.Add(detailsButton, 1, i);
                tlp.Controls.Add(editDetailsButton, 2, i);
                tlp.Controls.Add(removeButton, 3, i);
            }
        }
        private void OutletDetails_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Outlet outlet = (Outlet)btn.Tag;
            this.Hide();
            new OutletDetails(this, outlet).Show();
        }

        private void editDetailsButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Outlet outlet = (Outlet)btn.Tag;
            this.Hide();
            new EditOutletDetailsForm(prev, this, outlet).Show();
        }
        private void RemoveOutlet_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Outlet outlet = (Outlet)btn.Tag;

            DialogResult choice = MessageBox.Show("Are you sure you want to delete this outlet?",
                                          "Confirm Deletion",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes)
            {
                DatabaseConnection.removeStock(outlet.Outlet_id);
                DatabaseConnection.removeOutlet(outlet.Outlet_id);
                MessageBox.Show("Outlet removed permanently",
                                          "Deletion successful",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                this.Close();
                prev.Show();
            }
        }


        private void ManageOutletForm_Load(object sender, EventArgs e)
        {

        }

        private void tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }
    }
}
