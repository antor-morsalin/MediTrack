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
    public partial class ManageInventoryForm : Form
    {
        Form prev; User user;
        public ManageInventoryForm(Form prev, User user)
        {
            InitializeComponent();
            this.prev = prev;
            this.user = user;

            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            List<Outlet> outletList = new List<Outlet>();
            outletList = DatabaseConnection.getOutlets(user.User_name);

            tlp.RowCount = outletList.Count;

            foreach (RowStyle row in tlp.RowStyles)
            {
                row.SizeType = SizeType.Absolute;
                row.Height = 60;
            }

            for(int i = 0; i < outletList.Count; i++)
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
                Button viewStockButton = new Button
                {
                    Text = "View Stock",
                    Tag = outlet,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)

                };
                viewStockButton.Click += viewStockButton_Click;
                tlp.Controls.Add(nameLabel, 0, i);
                tlp.Controls.Add(viewStockButton, 1, i);
            }
        }

        private void viewStockButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Outlet outlet = (Outlet)btn.Tag;
            this.Hide();
            new ViewStockForm(outlet, this).Show();
        }

        private void ManageInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }
    }
}
