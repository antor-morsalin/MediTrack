namespace MediTrackForms
{
    partial class ManageOutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOutletForm));
            panel1 = new Panel();
            tlp = new TableLayoutPanel();
            back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tlp);
            panel1.Location = new Point(574, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 632);
            panel1.TabIndex = 0;
            // 
            // tlp
            // 
            tlp.AutoScroll = true;
            tlp.BackColor = Color.Transparent;
            tlp.ColumnCount = 4;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.Location = new Point(3, 3);
            tlp.Name = "tlp";
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp.Size = new Size(921, 625);
            tlp.TabIndex = 0;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.BackgroundImage = (Image)resources.GetObject("back.BackgroundImage");
            back.BackgroundImageLayout = ImageLayout.Stretch;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Location = new Point(37, 674);
            back.Name = "back";
            back.Size = new Size(150, 150);
            back.TabIndex = 2;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // ManageOutletForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(back);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageOutletForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOutlet";
            Load += ManageOutletForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlp;
        private Button back;
    }
}