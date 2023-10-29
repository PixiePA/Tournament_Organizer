namespace Tournament_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayerRegistration_Click(object sender, EventArgs e)
        {
            PlayerRegistrationForm prForm = new PlayerRegistrationForm(this);
            prForm.Show();
            this.Hide();
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            TeamViewEditForm tveForm = new TeamViewEditForm(this);
            tveForm.Show();
            this.Hide();
        }

        private void btnTeamRegistration_Click(object sender, EventArgs e)
        {
            TeamRegistrationForm trForm = new TeamRegistrationForm(this);
            trForm.Show();
            this.Hide();
        }

        private void btnTournamentCreation_Click(object sender, EventArgs e)
        {
            TournamentCreationForm tcForm = new TournamentCreationForm(this);
            tcForm.Show();
            this.Hide();
        }
    }
}