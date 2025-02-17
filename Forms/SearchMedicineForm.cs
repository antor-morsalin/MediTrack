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
    public partial class SearchMedicineForm : Form
    {
        Form prev; User user;
        List<Medicine> medicines = new List<Medicine>();
        
        public SearchMedicineForm(Form prev,List<Medicine> medicines, User user)
        {
            InitializeComponent();


            reset.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            reset.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            this.prev = prev;
            this.medicines = medicines;
            this.user = user;

            back.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            back.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            search_.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 239, 182, 200);
            search_.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 231, 143, 129);

            loadAllMedicine(medicines);

        }

        public void loadAllMedicine(List<Medicine> medicines)
        {
            tlp.Controls.Clear(); 
            tlp.RowStyles.Clear();

            tlp.RowCount = medicines.Count;

            foreach (RowStyle row in tlp.RowStyles)
            {
                row.SizeType = SizeType.Absolute;
                row.Height = 60;
            }

            for (int i = 0; i < medicines.Count; i++)
            {
                Medicine medicine = medicines[i];
                Label nameLabel = new Label
                {
                    Text = medicine.Medicine_name,
                    Font = new Font("MS Reference Sans Serif", 14),
                    Margin = new Padding(5),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill
                };

                Button detailsButton = new Button
                {
                    Text = "Medicine Details",
                    Tag = medicine,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                };
                detailsButton.Click += BtnDetails_Click;

                Button loadSimilarButton = new Button
                {
                    Text = "Load Similar",
                    Tag = medicine.Grp,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                };
                loadSimilarButton.Click += BtnLoadSimilar_Click;

                Button addToStockButton = new Button
                {
                    Text = "Add to stock",
                    Tag = medicine,
                    Margin = new Padding(5),
                    Size = new Size(140, 50)
                };
                addToStockButton.Click += addToStockButton_Click;

                tlp.Controls.Add(nameLabel, 0, i);
                tlp.Controls.Add(detailsButton, 1, i);
                tlp.Controls.Add(loadSimilarButton, 2, i);
                tlp.Controls.Add(addToStockButton, 3, i);

            }

        }
        private void BtnDetails_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Medicine medicine = (Medicine)btn.Tag;
            this.Hide();
            new MedicineDetailsForm(this, medicine).Show();
        }
        private void BtnLoadSimilar_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string groupName = (string)btn.Tag;
            List<Medicine> medicines = new List<Medicine>();
            medicines = DatabaseConnection.getMedKeyWord(groupName);
            this.Hide();
            new SearchMedicineForm(this, medicines, user).Show();
        }
        private void addToStockButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Medicine medicine = (Medicine)btn.Tag;
            this.Hide();
            new AddToStockForm(this, medicine, user).Show();
        }

        private void SearchMedicineForm_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            List<Medicine> medicines = new List<Medicine>();
            medicines = DatabaseConnection.getAllMedicine();
            new SearchMedicineForm(prev, medicines, user).Show();
            this.Close();
        }

        private void search__Click(object sender, EventArgs e)
        {
            string keyWord = searchBox.Text.Trim();
            if (keyWord.Length != 0)
            {
                List<Medicine> medicines = new List<Medicine>();
                medicines = DatabaseConnection.getMedKeyWord(keyWord);
                new SearchMedicineForm(this, medicines, user).Show();
            }
        }
    }
}
