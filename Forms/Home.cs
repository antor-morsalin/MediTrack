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
    public partial class HomeForm : Form
    {
        public static User user; Form prev;
        public HomeForm(User user, Form prev)
        {
            HomeForm.user = user;
            this.prev = prev;

            InitializeComponent();
            manageOutlet.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 138, 138);
            manageOutlet.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 138, 138);

            searchMedicine.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 138, 138);
            searchMedicine.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 138, 138);

            settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 138, 138);
            settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 138, 138);

            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 138, 138);
            logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 138, 138);

            exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 138, 138);
            exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 138, 138);

            AddOutlet.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 253, 223, 210);
            AddOutlet.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);

            ManageInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 253, 223, 210);
            ManageInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 138, 138);
            
        }

        private void manageOutlet_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageOutletForm(this, user).Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void AddOutlet_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddOutletForm(this, user).Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            new SettingsForm(this, user).Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchMedicine_Click(object sender, EventArgs e)
        {
            List<Medicine> medicines = new List<Medicine>();
            medicines = DatabaseConnection.getAllMedicine();
            this.Hide();
            new SearchMedicineForm(this, medicines, user).Show();
        }

        private void ManageInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageInventoryForm(this, user).Show();
        }
    }
}
