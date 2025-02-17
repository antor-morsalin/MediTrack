namespace MediTrackForms
{
    partial class EditOutletDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOutletDetailsForm));
            nameTb = new TextBox();
            addressTb = new TextBox();
            contactTb = new TextBox();
            backBtn = new Button();
            updateDetailsBtn = new Button();
            SuspendLayout();
            // 
            // nameTb
            // 
            nameTb.BackColor = Color.FromArgb(255, 242, 230);
            nameTb.BorderStyle = BorderStyle.None;
            nameTb.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTb.ForeColor = Color.Black;
            nameTb.Location = new Point(515, 147);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(627, 31);
            nameTb.TabIndex = 0;
            // 
            // addressTb
            // 
            addressTb.BackColor = Color.FromArgb(255, 242, 230);
            addressTb.BorderStyle = BorderStyle.None;
            addressTb.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTb.ForeColor = Color.Black;
            addressTb.Location = new Point(515, 340);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(627, 31);
            addressTb.TabIndex = 1;
            // 
            // contactTb
            // 
            contactTb.BackColor = Color.FromArgb(255, 242, 230);
            contactTb.BorderStyle = BorderStyle.None;
            contactTb.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactTb.ForeColor = Color.Black;
            contactTb.Location = new Point(515, 536);
            contactTb.Name = "contactTb";
            contactTb.Size = new Size(627, 31);
            contactTb.TabIndex = 2;
            contactTb.TextChanged += textBox1_TextChanged;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = SystemColors.ControlText;
            backBtn.Location = new Point(44, 657);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(150, 150);
            backBtn.TabIndex = 3;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // updateDetailsBtn
            // 
            updateDetailsBtn.BackColor = Color.FromArgb(135, 35, 65);
            updateDetailsBtn.FlatAppearance.BorderSize = 0;
            updateDetailsBtn.FlatStyle = FlatStyle.Flat;
            updateDetailsBtn.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateDetailsBtn.ForeColor = Color.White;
            updateDetailsBtn.Location = new Point(479, 677);
            updateDetailsBtn.Name = "updateDetailsBtn";
            updateDetailsBtn.Size = new Size(695, 130);
            updateDetailsBtn.TabIndex = 4;
            updateDetailsBtn.Text = "Update";
            updateDetailsBtn.UseVisualStyleBackColor = false;
            updateDetailsBtn.Click += updateDetailsBtn_Click;
            // 
            // EditOutletDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(updateDetailsBtn);
            Controls.Add(backBtn);
            Controls.Add(contactTb);
            Controls.Add(addressTb);
            Controls.Add(nameTb);
            Name = "EditOutletDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditOutletDetails";
            Load += EditOutletDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTb;
        private TextBox addressTb;
        private TextBox contactTb;
        private Button backBtn;
        private Button updateDetailsBtn;
    }
}