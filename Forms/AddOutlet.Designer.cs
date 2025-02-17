namespace MediTrackForms
{
    partial class AddOutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOutletForm));
            OutletNameTb = new TextBox();
            OutletAddressTb = new TextBox();
            OutletContactTb = new TextBox();
            AddOutletBtn = new Button();
            AddOutletBackBtn = new Button();
            SuspendLayout();
            // 
            // OutletNameTb
            // 
            OutletNameTb.BackColor = Color.FromArgb(255, 242, 230);
            OutletNameTb.BorderStyle = BorderStyle.None;
            OutletNameTb.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutletNameTb.Location = new Point(517, 145);
            OutletNameTb.Name = "OutletNameTb";
            OutletNameTb.Size = new Size(616, 37);
            OutletNameTb.TabIndex = 0;
            // 
            // OutletAddressTb
            // 
            OutletAddressTb.BackColor = Color.FromArgb(255, 242, 230);
            OutletAddressTb.BorderStyle = BorderStyle.None;
            OutletAddressTb.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutletAddressTb.Location = new Point(517, 339);
            OutletAddressTb.Name = "OutletAddressTb";
            OutletAddressTb.Size = new Size(616, 37);
            OutletAddressTb.TabIndex = 1;
            OutletAddressTb.TextChanged += textBox2_TextChanged;
            // 
            // OutletContactTb
            // 
            OutletContactTb.BackColor = Color.FromArgb(255, 242, 230);
            OutletContactTb.BorderStyle = BorderStyle.None;
            OutletContactTb.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutletContactTb.Location = new Point(517, 533);
            OutletContactTb.Name = "OutletContactTb";
            OutletContactTb.Size = new Size(616, 37);
            OutletContactTb.TabIndex = 2;
            // 
            // AddOutletBtn
            // 
            AddOutletBtn.BackColor = Color.FromArgb(135, 35, 65);
            AddOutletBtn.FlatAppearance.BorderSize = 0;
            AddOutletBtn.FlatStyle = FlatStyle.Flat;
            AddOutletBtn.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddOutletBtn.ForeColor = Color.White;
            AddOutletBtn.Location = new Point(479, 677);
            AddOutletBtn.Name = "AddOutletBtn";
            AddOutletBtn.Size = new Size(695, 130);
            AddOutletBtn.TabIndex = 3;
            AddOutletBtn.Text = "Add outlet";
            AddOutletBtn.UseVisualStyleBackColor = false;
            AddOutletBtn.Click += AddOutletBtn_Click;
            // 
            // AddOutletBackBtn
            // 
            AddOutletBackBtn.BackColor = Color.Transparent;
            AddOutletBackBtn.BackgroundImage = (Image)resources.GetObject("AddOutletBackBtn.BackgroundImage");
            AddOutletBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AddOutletBackBtn.FlatAppearance.BorderSize = 0;
            AddOutletBackBtn.FlatStyle = FlatStyle.Flat;
            AddOutletBackBtn.Location = new Point(51, 657);
            AddOutletBackBtn.Name = "AddOutletBackBtn";
            AddOutletBackBtn.Size = new Size(150, 150);
            AddOutletBackBtn.TabIndex = 4;
            AddOutletBackBtn.UseVisualStyleBackColor = false;
            AddOutletBackBtn.Click += AddOutletBackBtn_Click;
            // 
            // AddOutletForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(AddOutletBackBtn);
            Controls.Add(AddOutletBtn);
            Controls.Add(OutletContactTb);
            Controls.Add(OutletAddressTb);
            Controls.Add(OutletNameTb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOutletForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOutlet";
            Load += AddOutletForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OutletNameTb;
        private TextBox OutletAddressTb;
        private TextBox OutletContactTb;
        private Button AddOutletBtn;
        private Button AddOutletBackBtn;
    }
}