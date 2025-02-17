namespace MediTrackForms
{
    partial class OutletDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutletDetails));
            backBtn = new Button();
            nameLabel = new Label();
            addressLabel = new Label();
            contactLabel = new Label();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(51, 654);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(150, 150);
            backBtn.TabIndex = 0;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(547, 206);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(527, 94);
            nameLabel.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.Location = new Point(547, 423);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(527, 94);
            addressLabel.TabIndex = 2;
            // 
            // contactLabel
            // 
            contactLabel.BackColor = Color.Transparent;
            contactLabel.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactLabel.Location = new Point(547, 635);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(527, 94);
            contactLabel.TabIndex = 3;
            // 
            // OutletDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(contactLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(backBtn);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OutletDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OutletDetails";
            Load += OutletDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Label nameLabel;
        private Label addressLabel;
        private Label contactLabel;
    }
}