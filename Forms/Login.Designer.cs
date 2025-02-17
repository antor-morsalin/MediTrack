namespace MediTrackForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginUsernameTb = new TextBox();
            LoginPasswordTb = new TextBox();
            LoginLoginBtn = new Button();
            LoginBackBtn = new Button();
            SuspendLayout();
            // 
            // LoginUsernameTb
            // 
            LoginUsernameTb.BackColor = Color.FromArgb(226, 109, 109);
            LoginUsernameTb.BorderStyle = BorderStyle.None;
            LoginUsernameTb.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUsernameTb.Location = new Point(156, 273);
            LoginUsernameTb.Name = "LoginUsernameTb";
            LoginUsernameTb.Size = new Size(472, 28);
            LoginUsernameTb.TabIndex = 0;
            // 
            // LoginPasswordTb
            // 
            LoginPasswordTb.BackColor = Color.FromArgb(226, 109, 109);
            LoginPasswordTb.BorderStyle = BorderStyle.None;
            LoginPasswordTb.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginPasswordTb.Location = new Point(156, 451);
            LoginPasswordTb.Name = "LoginPasswordTb";
            LoginPasswordTb.PasswordChar = '*';
            LoginPasswordTb.Size = new Size(472, 28);
            LoginPasswordTb.TabIndex = 1;
            // 
            // LoginLoginBtn
            // 
            LoginLoginBtn.BackColor = Color.FromArgb(116, 9, 56);
            LoginLoginBtn.FlatAppearance.BorderSize = 0;
            LoginLoginBtn.FlatStyle = FlatStyle.Flat;
            LoginLoginBtn.Font = new Font("MS Reference Sans Serif", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLoginBtn.ForeColor = Color.White;
            LoginLoginBtn.Location = new Point(118, 578);
            LoginLoginBtn.Name = "LoginLoginBtn";
            LoginLoginBtn.Size = new Size(549, 104);
            LoginLoginBtn.TabIndex = 2;
            LoginLoginBtn.Text = "Login";
            LoginLoginBtn.UseVisualStyleBackColor = false;
            LoginLoginBtn.Click += LoginLoginBtn_Click;
            // 
            // LoginBackBtn
            // 
            LoginBackBtn.BackColor = Color.Transparent;
            LoginBackBtn.BackgroundImage = (Image)resources.GetObject("LoginBackBtn.BackgroundImage");
            LoginBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBackBtn.FlatAppearance.BorderSize = 0;
            LoginBackBtn.FlatStyle = FlatStyle.Flat;
            LoginBackBtn.Location = new Point(1417, 691);
            LoginBackBtn.Name = "LoginBackBtn";
            LoginBackBtn.Size = new Size(150, 150);
            LoginBackBtn.TabIndex = 3;
            LoginBackBtn.UseVisualStyleBackColor = false;
            LoginBackBtn.Click += LoginBackBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(LoginBackBtn);
            Controls.Add(LoginLoginBtn);
            Controls.Add(LoginPasswordTb);
            Controls.Add(LoginUsernameTb);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginUsernameTb;
        private TextBox LoginPasswordTb;
        private Button LoginLoginBtn;
        private Button LoginBackBtn;
    }
}