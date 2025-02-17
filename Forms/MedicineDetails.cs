using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediTrackForms
{
    public partial class MedicineDetailsForm : Form
    {
        Form prev; Medicine medicine;
        public MedicineDetailsForm(Form prev, Medicine medicine)
        {
            InitializeComponent();
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 239, 182, 200);
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);
            this.prev = prev;
            this.medicine = medicine;
            //this.nameTb.Text = medicine.Medicine_name;
            label1.Text = medicine.Medicine_name;
            //this.mnfTb.Text = medicine.Manufacturer;
            label2.Text = medicine.Manufacturer;
            //this.grTb.Text = medicine.Grp;
            label3.Text = medicine.Grp;
            //this.dscTb.Text = medicine.Medicine_description;
            label4.Text = medicine.Medicine_description;
        }

        private void MedicineDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }
    }
}
