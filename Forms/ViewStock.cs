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
    public partial class ViewStockForm : Form
    {
        Outlet outlet; Form prev;
        public ViewStockForm(Outlet outlet, Form prev)
        {
            InitializeComponent();
            this.outlet = outlet;
            this.prev = prev;

            List<Stock> stockList = new List<Stock>();
            stockList = DatabaseConnection.getStockList(outlet.Outlet_id);
            tlp.RowCount = stockList.Count;

            foreach (RowStyle row in tlp.RowStyles)
            {
                row.SizeType = SizeType.Absolute;
                row.Height = 60;
            }


            for (int i = 0; i < stockList.Count; i++)
            {

                Stock stock = stockList[i];

                Label nameLabel = new Label
                {
                    Text = DatabaseConnection.getMedicineName(stock.MedicineId),
                    Font = new Font("MS Reference Sans Serif", 14),
                    Margin = new Padding(5),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill
                };
                Label qntLabel = new Label
                {
                    Text = Convert.ToString(stock.Quantity),
                    Font = new Font("MS Reference Sans Serif", 14),
                    Margin = new Padding(5),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill
                };
                Label expLabel = new Label
                {
                    Text = stock.ExpDate.ToString("yyyy-MM-dd"),
                    Font = new Font("MS Reference Sans Serif", 14),
                    Margin = new Padding(5),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill
                };
                NumericUpDown numericUpDown = new NumericUpDown
                {
                    Minimum = 1,  
                    Maximum = stock.Quantity, 
                    Value = 1,     
                    //Dock = DockStyle.Fill,
                    Font = new Font("MS Reference Sans Serif", 12),
                    Width = 100
                    
                };

                List<int> info = new List<int>();
                info.Add(stock.StockId);
                info.Add(i);

                Button removeButton = new Button
                {
                    Text = "Remove",
                    Tag = info,
                    Margin = new Padding(5),
                    Size = new Size(120, 35),
                    Font = new Font("MS Reference Sans Serif", 10)

                };
                removeButton.Click += RemoveOutlet_Click;

                tlp.Controls.Add(nameLabel, 0, i);
                tlp.Controls.Add(qntLabel, 1, i);
                tlp.Controls.Add(expLabel, 2, i);
                tlp.Controls.Add(numericUpDown, 3, i);
                tlp.Controls.Add(removeButton, 4, i);

            }

        }
        private void RemoveOutlet_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            List<int> info = new List<int>();
            info = (List<int>)btn.Tag;

            int stock_id = info[0];

            NumericUpDown numericUpDown = tlp.GetControlFromPosition(3, info[1]) as NumericUpDown;
            int quantity = Convert.ToInt32(numericUpDown.Value);

            DatabaseConnection.removeStock(stock_id, quantity);
            MessageBox.Show("Stock quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            this.Close();
            new ViewStockForm(outlet, prev).Show();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            prev.Show();
        }

        private void ViewStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
