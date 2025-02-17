namespace MediTrackForms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            manageOutlet = new Button();
            searchMedicine = new Button();
            settings = new Button();
            logout = new Button();
            exit = new Button();
            AddOutlet = new Button();
            ManageInventory = new Button();
            SuspendLayout();
            // 
            // manageOutlet
            // 
            manageOutlet.BackColor = Color.Transparent;
            manageOutlet.FlatAppearance.BorderSize = 0;
            manageOutlet.FlatStyle = FlatStyle.Flat;
            manageOutlet.Location = new Point(0, 187);
            manageOutlet.Name = "manageOutlet";
            manageOutlet.Size = new Size(390, 129);
            manageOutlet.TabIndex = 0;
            manageOutlet.UseVisualStyleBackColor = false;
            manageOutlet.Click += manageOutlet_Click;
            // 
            // searchMedicine
            // 
            searchMedicine.BackColor = Color.Transparent;
            searchMedicine.FlatAppearance.BorderSize = 0;
            searchMedicine.FlatStyle = FlatStyle.Flat;
            searchMedicine.Location = new Point(0, 316);
            searchMedicine.Name = "searchMedicine";
            searchMedicine.Size = new Size(390, 129);
            searchMedicine.TabIndex = 1;
            searchMedicine.UseVisualStyleBackColor = false;
            searchMedicine.Click += searchMedicine_Click;
            // 
            // settings
            // 
            settings.BackColor = Color.Transparent;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Location = new Point(0, 445);
            settings.Name = "settings";
            settings.Size = new Size(390, 129);
            settings.TabIndex = 2;
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(0, 574);
            logout.Name = "logout";
            logout.Size = new Size(390, 129);
            logout.TabIndex = 3;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(0, 703);
            exit.Name = "exit";
            exit.Size = new Size(390, 151);
            exit.TabIndex = 4;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // AddOutlet
            // 
            AddOutlet.BackColor = Color.Transparent;
            AddOutlet.FlatAppearance.BorderSize = 0;
            AddOutlet.FlatStyle = FlatStyle.Flat;
            AddOutlet.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddOutlet.Location = new Point(858, 226);
            AddOutlet.Name = "AddOutlet";
            AddOutlet.Size = new Size(646, 185);
            AddOutlet.TabIndex = 5;
            AddOutlet.Text = "Add Outlet";
            AddOutlet.UseVisualStyleBackColor = false;
            AddOutlet.Click += AddOutlet_Click;
            // 
            // ManageInventory
            // 
            ManageInventory.BackColor = Color.Transparent;
            ManageInventory.FlatAppearance.BorderSize = 0;
            ManageInventory.FlatStyle = FlatStyle.Flat;
            ManageInventory.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManageInventory.Location = new Point(866, 430);
            ManageInventory.Name = "ManageInventory";
            ManageInventory.Size = new Size(645, 182);
            ManageInventory.TabIndex = 6;
            ManageInventory.Text = "Manage Inventory";
            ManageInventory.UseVisualStyleBackColor = false;
            ManageInventory.Click += ManageInventory_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(ManageInventory);
            Controls.Add(AddOutlet);
            Controls.Add(exit);
            Controls.Add(logout);
            Controls.Add(settings);
            Controls.Add(searchMedicine);
            Controls.Add(manageOutlet);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manageOutlet;
        private Button searchMedicine;
        private Button settings;
        private Button logout;
        private Button exit;
        private Button AddOutlet;
        private Button ManageInventory;
    }
}