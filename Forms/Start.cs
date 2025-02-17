namespace MediTrackForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            StartSignupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 207, 179);
            StartSignupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

            StartLoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 207, 179);
            StartLoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 231, 143, 129);

        }

        private void StartSignupBtn_Click(object sender, EventArgs e)
        {
            new SignupForm(this).Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void StartLoginBtn_Click(object sender, EventArgs e)
        {
            new LoginForm(this).Show();
            this.Hide();
        }
    }
}
