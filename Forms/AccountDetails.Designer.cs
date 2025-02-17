namespace MediTrackForms
{
    partial class AccountDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            NameTb = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            DetailsBackBtn = new Button();
            SuspendLayout();
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.FromArgb(225, 97, 97);
            NameTb.BorderStyle = BorderStyle.None;
            NameTb.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.Location = new Point(526, 241);
            NameTb.Name = "NameTb";
            NameTb.ReadOnly = true;
            NameTb.Size = new Size(442, 31);
            NameTb.TabIndex = 0;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(225, 97, 97);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(526, 458);
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Size = new Size(442, 31);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(225, 97, 97);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(526, 676);
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Size = new Size(442, 31);
            Password.TabIndex = 2;
            // 
            // DetailsBackBtn
            // 
            DetailsBackBtn.BackColor = Color.Transparent;
            DetailsBackBtn.BackgroundImage = (Image)resources.GetObject("DetailsBackBtn.BackgroundImage");
            DetailsBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DetailsBackBtn.FlatAppearance.BorderSize = 0;
            DetailsBackBtn.FlatStyle = FlatStyle.Flat;
            DetailsBackBtn.Location = new Point(1392, 664);
            DetailsBackBtn.Name = "DetailsBackBtn";
            DetailsBackBtn.Size = new Size(150, 150);
            DetailsBackBtn.TabIndex = 3;
            DetailsBackBtn.UseVisualStyleBackColor = false;
            DetailsBackBtn.Click += DetailsBackBtn_Click;
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(DetailsBackBtn);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(NameTb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Details";
            Load += AccountDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTb;
        private TextBox Username;
        private TextBox Password;
        private Button DetailsBackBtn;
    }
}