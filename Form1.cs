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
            PlayerRegistrationForm prForm = new PlayerRegistrationForm();
            prForm.ShowDialog();
        }

        private void btnTeamRegistration_Click(object sender, EventArgs e)
        {
            TeamRegistrationForm trForm = new TeamRegistrationForm();
            trForm.ShowDialog();
        }

        private void btnTournamentCreation_Click(object sender, EventArgs e)
        {
            TournamentCreationForm tcForm = new TournamentCreationForm();
            tcForm.ShowDialog();
        }
    }
}