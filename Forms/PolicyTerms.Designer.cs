namespace MediTrackForms
{
    partial class PolicyTermsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolicyTermsForm));
            TermsPolicyBackBtn = new Button();
            SuspendLayout();
            // 
            // TermsPolicyBackBtn
            // 
            TermsPolicyBackBtn.BackColor = Color.Transparent;
            TermsPolicyBackBtn.BackgroundImage = (Image)resources.GetObject("TermsPolicyBackBtn.BackgroundImage");
            TermsPolicyBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            TermsPolicyBackBtn.FlatAppearance.BorderSize = 0;
            TermsPolicyBackBtn.FlatStyle = FlatStyle.Flat;
            TermsPolicyBackBtn.Location = new Point(26, 680);
            TermsPolicyBackBtn.Name = "TermsPolicyBackBtn";
            TermsPolicyBackBtn.Size = new Size(150, 150);
            TermsPolicyBackBtn.TabIndex = 0;
            TermsPolicyBackBtn.UseVisualStyleBackColor = false;
            TermsPolicyBackBtn.Click += TermsPolicyBackBtn_Click;
            // 
            // PolicyTermsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(TermsPolicyBackBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PolicyTermsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PolicyTerms";
            Load += PolicyTermsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button TermsPolicyBackBtn;
    }
}