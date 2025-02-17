namespace MediTrackForms
{
    partial class AddToStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToStockForm));
            backBtn = new Button();
            addBtn = new Button();
            nameLabel = new Label();
            mnfLabel = new Label();
            grpLabel = new Label();
            qntSelector = new NumericUpDown();
            outletCombo = new ComboBox();
            datepick = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)qntSelector).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(1378, 652);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(150, 150);
            backBtn.TabIndex = 0;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(116, 9, 56);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(665, 627);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(490, 85);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.FlatStyle = FlatStyle.Flat;
            nameLabel.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(107, 241);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(424, 25);
            nameLabel.TabIndex = 2;
            // 
            // mnfLabel
            // 
            mnfLabel.BackColor = Color.Transparent;
            mnfLabel.FlatStyle = FlatStyle.Flat;
            mnfLabel.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnfLabel.Location = new Point(107, 380);
            mnfLabel.Name = "mnfLabel";
            mnfLabel.Size = new Size(424, 25);
            mnfLabel.TabIndex = 3;
            mnfLabel.Click += label1_Click;
            // 
            // grpLabel
            // 
            grpLabel.BackColor = Color.Transparent;
            grpLabel.FlatStyle = FlatStyle.Flat;
            grpLabel.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpLabel.Location = new Point(107, 519);
            grpLabel.Name = "grpLabel";
            grpLabel.Size = new Size(424, 25);
            grpLabel.TabIndex = 4;
            // 
            // qntSelector
            // 
            qntSelector.BorderStyle = BorderStyle.None;
            qntSelector.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qntSelector.Location = new Point(107, 661);
            qntSelector.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            qntSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            qntSelector.Name = "qntSelector";
            qntSelector.Size = new Size(441, 31);
            qntSelector.TabIndex = 5;
            qntSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // outletCombo
            // 
            outletCombo.DropDownWidth = 300;
            outletCombo.FlatStyle = FlatStyle.System;
            outletCombo.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outletCombo.FormattingEnabled = true;
            outletCombo.Location = new Point(665, 230);
            outletCombo.MaxDropDownItems = 50;
            outletCombo.Name = "outletCombo";
            outletCombo.Size = new Size(490, 36);
            outletCombo.TabIndex = 6;
            // 
            // datepick
            // 
            datepick.CalendarFont = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datepick.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datepick.Location = new Point(665, 370);
            datepick.MinDate = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            datepick.Name = "datepick";
            datepick.Size = new Size(490, 35);
            datepick.TabIndex = 7;
            // 
            // AddToStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(datepick);
            Controls.Add(outletCombo);
            Controls.Add(qntSelector);
            Controls.Add(grpLabel);
            Controls.Add(mnfLabel);
            Controls.Add(nameLabel);
            Controls.Add(addBtn);
            Controls.Add(backBtn);
            DoubleBuffered = true;
            Name = "AddToStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddToStock";
            Load += AddToStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)qntSelector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Button addBtn;
        private Label nameLabel;
        private Label mnfLabel;
        private Label grpLabel;
        private NumericUpDown qntSelector;
        private ComboBox outletCombo;
        private DateTimePicker datepick;
    }
}