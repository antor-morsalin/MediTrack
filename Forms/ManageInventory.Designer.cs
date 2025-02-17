namespace MediTrackForms
{
    partial class ManageInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventoryForm));
            backBtn = new Button();
            panel1 = new Panel();
            tlp = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(57, 658);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(150, 150);
            backBtn.TabIndex = 0;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tlp);
            panel1.Location = new Point(491, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 686);
            panel1.TabIndex = 1;
            // 
            // tlp
            // 
            tlp.AutoScroll = true;
            tlp.AutoSize = true;
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp.Location = new Point(3, 3);
            tlp.Name = "tlp";
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp.Size = new Size(601, 60);
            tlp.TabIndex = 0;
            // 
            // ManageInventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageInventory";
            Load += ManageInventoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Panel panel1;
        private TableLayoutPanel tlp;
    }
}