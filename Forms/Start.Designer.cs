namespace MediTrackForms
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            StartSignupBtn = new Button();
            StartLoginBtn = new Button();
            SuspendLayout();
            // 
            // StartSignupBtn
            // 
            StartSignupBtn.BackColor = Color.Transparent;
            StartSignupBtn.FlatAppearance.BorderSize = 0;
            StartSignupBtn.FlatStyle = FlatStyle.Flat;
            StartSignupBtn.Location = new Point(1093, 28);
            StartSignupBtn.Name = "StartSignupBtn";
            StartSignupBtn.Size = new Size(175, 60);
            StartSignupBtn.TabIndex = 0;
            StartSignupBtn.UseVisualStyleBackColor = false;
            StartSignupBtn.Click += StartSignupBtn_Click;
            // 
            // StartLoginBtn
            // 
            StartLoginBtn.BackColor = Color.Transparent;
            StartLoginBtn.FlatAppearance.BorderSize = 0;
            StartLoginBtn.FlatStyle = FlatStyle.Flat;
            StartLoginBtn.Location = new Point(1274, 28);
            StartLoginBtn.Name = "StartLoginBtn";
            StartLoginBtn.Size = new Size(141, 60);
            StartLoginBtn.TabIndex = 1;
            StartLoginBtn.UseVisualStyleBackColor = false;
            StartLoginBtn.Click += StartLoginBtn_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(StartLoginBtn);
            Controls.Add(StartSignupBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            Load += Start_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button StartSignupBtn;
        private Button StartLoginBtn;
    }
}
