namespace MediTrackForms
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            SignupSignupBtn = new Button();
            FirstNameTb = new TextBox();
            LastnameTb = new TextBox();
            SignupUsernameTb = new TextBox();
            SignupPasswordTb = new TextBox();
            signUpBackBtn = new Button();
            SuspendLayout();
            // 
            // SignupSignupBtn
            // 
            SignupSignupBtn.BackColor = Color.FromArgb(135, 35, 65);
            SignupSignupBtn.FlatAppearance.BorderSize = 0;
            SignupSignupBtn.FlatStyle = FlatStyle.Flat;
            SignupSignupBtn.Font = new Font("Sans Serif Collection", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupSignupBtn.ForeColor = Color.Transparent;
            SignupSignupBtn.Location = new Point(877, 639);
            SignupSignupBtn.Name = "SignupSignupBtn";
            SignupSignupBtn.Size = new Size(604, 92);
            SignupSignupBtn.TabIndex = 1;
            SignupSignupBtn.Text = "Signup";
            SignupSignupBtn.UseVisualStyleBackColor = false;
            SignupSignupBtn.Click += SignupSignupBtn_Click;
            // 
            // FirstNameTb
            // 
            FirstNameTb.BackColor = Color.FromArgb(226, 109, 109);
            FirstNameTb.BorderStyle = BorderStyle.None;
            FirstNameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameTb.Location = new Point(912, 143);
            FirstNameTb.MaxLength = 20;
            FirstNameTb.Name = "FirstNameTb";
            FirstNameTb.Size = new Size(233, 31);
            FirstNameTb.TabIndex = 2;
            FirstNameTb.TextChanged += FirstNameTb_TextChanged_1;
            // 
            // LastnameTb
            // 
            LastnameTb.BackColor = Color.FromArgb(226, 109, 109);
            LastnameTb.BorderStyle = BorderStyle.None;
            LastnameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastnameTb.Location = new Point(1226, 143);
            LastnameTb.MaxLength = 20;
            LastnameTb.Name = "LastnameTb";
            LastnameTb.Size = new Size(233, 31);
            LastnameTb.TabIndex = 3;
            // 
            // SignupUsernameTb
            // 
            SignupUsernameTb.BackColor = Color.FromArgb(226, 109, 109);
            SignupUsernameTb.BorderStyle = BorderStyle.None;
            SignupUsernameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupUsernameTb.Location = new Point(912, 326);
            SignupUsernameTb.MaxLength = 20;
            SignupUsernameTb.Name = "SignupUsernameTb";
            SignupUsernameTb.Size = new Size(532, 31);
            SignupUsernameTb.TabIndex = 4;
            SignupUsernameTb.TextChanged += SignupUsernameTb_TextChanged;
            // 
            // SignupPasswordTb
            // 
            SignupPasswordTb.BackColor = Color.FromArgb(226, 109, 109);
            SignupPasswordTb.BorderStyle = BorderStyle.None;
            SignupPasswordTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupPasswordTb.Location = new Point(913, 509);
            SignupPasswordTb.MaxLength = 50;
            SignupPasswordTb.Name = "SignupPasswordTb";
            SignupPasswordTb.PasswordChar = '*';
            SignupPasswordTb.Size = new Size(532, 31);
            SignupPasswordTb.TabIndex = 5;
            // 
            // signUpBackBtn
            // 
            signUpBackBtn.BackColor = Color.Transparent;
            signUpBackBtn.BackgroundImage = (Image)resources.GetObject("signUpBackBtn.BackgroundImage");
            signUpBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            signUpBackBtn.FlatAppearance.BorderSize = 0;
            signUpBackBtn.FlatStyle = FlatStyle.Flat;
            signUpBackBtn.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpBackBtn.Location = new Point(25, 678);
            signUpBackBtn.Name = "signUpBackBtn";
            signUpBackBtn.Size = new Size(150, 150);
            signUpBackBtn.TabIndex = 6;
            signUpBackBtn.TextAlign = ContentAlignment.TopCenter;
            signUpBackBtn.UseVisualStyleBackColor = false;
            signUpBackBtn.Click += button1_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(signUpBackBtn);
            Controls.Add(SignupPasswordTb);
            Controls.Add(SignupUsernameTb);
            Controls.Add(LastnameTb);
            Controls.Add(FirstNameTb);
            Controls.Add(SignupSignupBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SignupSignupBtn;
        private TextBox FirstNameTb;
        private TextBox LastnameTb;
        private TextBox SignupUsernameTb;
        private TextBox SignupPasswordTb;
        private Button signUpBackBtn;
    }
}