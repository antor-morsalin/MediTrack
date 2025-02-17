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
    public partial class OutletDetails : Form
    {
        Form prev; Outlet outlet;
        public OutletDetails(Form prev, Outlet outlet)
        {
            InitializeComponent();
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);
            this.prev = prev;
            this.outlet = outlet;

            this.nameLabel.Text = outlet.Outlet_name;
            this.addressLabel.Text = outlet.Outlet_address;
            this.contactLabel.Text = outlet.Outlet_contact;
        }

        private void OutletDetails_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();

        }
    }
}
