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
    public partial class AddToStockForm : Form
    {
        Form prev; Medicine medicine; User user;
        public AddToStockForm(Form prev, Medicine medicine, User user)
        {
            InitializeComponent();
            this.prev = prev;
            this.medicine = medicine;
            this.user = user;

            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            nameLabel.Text = medicine.Medicine_name;
            mnfLabel.Text = medicine.Manufacturer;
            grpLabel.Text = medicine.Grp;

            datepick.MinDate = DateTime.Today;
            datepick.Value = DateTime.Today;

            List <Outlet>  outlets = new List <Outlet>();
            outlets = DatabaseConnection.getOutlets(HomeForm.user.User_name);

            List<string> comboSource = new List<string>();
            foreach(Outlet outlet in outlets)
            {
                comboSource.Add(outlet.Outlet_name);
            }
            outletCombo.DataSource = comboSource;
            outletCombo.SelectedIndex = 0;
        }

        private void AddToStockForm_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int quantity = (int)qntSelector.Value;
            DateTime exp_date = new DateTime();
            exp_date = datepick.Value;
            string outlet_name = outletCombo.Text;

            DatabaseConnection.addToStock(medicine.Medicine_id,outlet_name, quantity, exp_date, user.User_name);
            MessageBox.Show("Added to the stock successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            prev.Show();
        }
    }
}
