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
    }
}