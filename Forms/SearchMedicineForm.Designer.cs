namespace MediTrackForms
{
    partial class SearchMedicineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMedicineForm));
            back = new Button();
            panel1 = new Panel();
            tlp = new TableLayoutPanel();
            search_ = new Button();
            reset = new Button();
            searchBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.BackgroundImage = (Image)resources.GetObject("back.BackgroundImage");
            back.BackgroundImageLayout = ImageLayout.Stretch;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Location = new Point(50, 657);
            back.Name = "back";
            back.Size = new Size(150, 150);
            back.TabIndex = 0;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tlp);
            panel1.Location = new Point(357, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 616);
            panel1.TabIndex = 1;
            // 
            // tlp
            // 
            tlp.AutoScroll = true;
            tlp.ColumnCount = 4;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.Location = new Point(3, 3);
            tlp.Name = "tlp";
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp.Size = new Size(1150, 588);
            tlp.TabIndex = 0;
            tlp.Paint += tlp_Paint;
            // 
            // search_
            // 
            search_.BackColor = Color.Transparent;
            search_.FlatAppearance.BorderSize = 0;
            search_.FlatStyle = FlatStyle.Flat;
            search_.Location = new Point(1255, 51);
            search_.Name = "search_";
            search_.Size = new Size(95, 84);
            search_.TabIndex = 2;
            search_.UseVisualStyleBackColor = false;
            search_.Click += search__Click;
            // 
            // reset
            // 
            reset.BackColor = Color.Transparent;
            reset.FlatAppearance.BorderSize = 0;
            reset.FlatStyle = FlatStyle.Flat;
            reset.Location = new Point(1403, 51);
            reset.Name = "reset";
            reset.Size = new Size(107, 111);
            reset.TabIndex = 3;
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(379, 80);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(870, 34);
            searchBox.TabIndex = 4;
            // 
            // SearchMedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(searchBox);
            Controls.Add(reset);
            Controls.Add(search_);
            Controls.Add(panel1);
            Controls.Add(back);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchMedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchMedicine";
            Load += SearchMedicineForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Panel panel1;
        private TableLayoutPanel tlp;
        private Button search_;
        private Button reset;
        private TextBox searchBox;
    }
}