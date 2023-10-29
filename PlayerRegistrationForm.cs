using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace Tournament_Tracker
{
    public partial class PlayerRegistrationForm : Form
    {
        private bool hasATeam;
        private Form1 menu;
        private List<Team> teams;
        public PlayerRegistrationForm(Form1 menu)
        {

            InitializeComponent();
            this.menu = menu;
            hasATeam = true;
            teams = DatabaseManager.context.Teams.ToList();
        }

        private void PlayerRegistrationForm_Load(object sender, EventArgs e)
        {
            // Load all teams into the team combo box
            foreach (Team team in teams)
            {
                cbTeams.Items.Add(team);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Player player = new();

            // Populate details into a new player object into the list and add the player into the team
            if (hasATeam)
            {
                // Check all inputs and ensure that the team selected isn't null
                if (ValidateInputs() && cbTeams.SelectedItem is Team selectedTeam)
                {
                    player = new Player(tbPlayerName.Text, 0, tbPlayerEmail.Text);
                    DatabaseManager.context.Players.Add(player);
                    selectedTeam.RegisterToTeam(player);
                    DatabaseManager.Save();

                    this.Close();
                    menu.Show();
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "You must add a name and email. You must also choose a team or select \"I don't have a team\".";
                }
            }
            // Create a new team for the player
            else
            {
                if (ValidateInputs())
                {
                    player = new Player(tbPlayerName.Text, 0, tbPlayerEmail.Text);
                    Team newTeam = new Team(tbPlayerName.Text + "Team");
                    DatabaseManager.context.Teams.Add(newTeam);
                    newTeam.RegisterToTeam(player);

                    this.Close();
                    menu.Show();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }

        private void sendPlayerEmail(Player player)
        {

        }

        // Validate that there is a name and email and they're in the correct format
        private bool ValidateInputs()
        {
            if (tbPlayerEmail.Text.Length > 0 && tbPlayerName.Text.Length > 0)
            {
                // Check that the email has valid characters + @ + valid characters + . + valid characters
                if (Regex.IsMatch(tbPlayerEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    lblError.Visible = false;
                    return true;
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Please enter a valid email address";
                    return false;
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "You must add a name and email. You must also choose a team or select \"I don't have a team\".";
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void PlayerRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbPlayerEmail.Text = string.Empty;
            tbPlayerName.Text = string.Empty;
            cbTeams.Items.Clear();
            cbTeams.Visible = true;
            btnNoTeam.BackColor = SystemColors.Control;
        }

        // Toggle the no team button
        private void btnNoTeam_Click(object sender, EventArgs e)
        {
            if (hasATeam)
            {
                btnNoTeam.BackColor = SystemColors.ControlDark;
                cbTeams.Visible = false;
                hasATeam = false;

                lblChooseTeam.Text = String.Format("A new team will be created for you with the name: {0}Team", tbPlayerName.Text);
            }
            else
            {
                btnNoTeam.BackColor = SystemColors.Control;
                cbTeams.Visible = true;
                lblChooseTeam.Text = "Choose a team:";
                hasATeam = true;
            }
        }
    }
}
