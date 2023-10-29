using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tournament_Tracker
{
    public partial class TournamentCreationForm : Form
    {
        private Form1 menu;
        private List<Team> teams;
        public TournamentCreationForm(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
            teams = DatabaseManager.context.Teams.ToList();
        }

        private void TournamentCreationForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in teams)
            {
                lbTeamSelection.Items.Add(team);
            }
        }

        // Add the teams selected in the list box
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((lbTeamSelection.SelectedItem as Team) is Team team)
            {
                // Check that the team being added isn't already there and that there's still under 16 teams
                if (!lbTeamFinal.Items.Contains(team) && lbTeamFinal.Items.Count < 16)
                {
                    lbTeamFinal.Items.Add(team);
                }
            }

            // Clear selection when adding a team for aesthetic purposes
            lbTeamSelection.SelectedItems.Clear();

            // Validate tournament size
            InputValidation();
        }

        // Remove the team selected when remove button is clicked
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((lbTeamFinal.SelectedItem as Team) is Team team)
            {
                lbTeamFinal.Items.Remove(team);
            }

            // Validate tournament size
            InputValidation();
        }

        // Validate the number of teams
        private void InputValidation()
        {
            // Check amount of teams selected and that the tournament name is selected
            if ((lbTeamFinal.Items.Count == 4 || lbTeamFinal.Items.Count == 8 || lbTeamFinal.Items.Count == 12 || lbTeamFinal.Items.Count == 16) && tbTournamentName.Text.Length > 0)
            {
                lblError.Visible = false;
                btnSubmit.Visible = true;
            }
            else
            {
                lblError.Visible = true;
                btnSubmit.Visible = false;

            }

        }
        // Create a new tournament depending on the type selected. If there is no type selected then return the error message.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create tournament with tournament name, type and teams selected
            Tournament tournament = new Tournament();
            tournament.TournamentName = tbTournamentName.Text;

            if (cbTournamentType.SelectedIndex == 0 && tbTournamentName.Text.Length > 0)
            {
                WinnersBracket bracket = new WinnersBracket();
                bracket.Tournament = tournament;
                DatabaseManager.context.WinnersBrackets.Add(bracket);
            }
            else if (cbTournamentType.SelectedIndex == 1 && tbTournamentName.Text.Length > 0)
            {
                LosersBracket bracket = new LosersBracket();
                bracket.Tournament = tournament;
                DatabaseManager.context.LosersBrackets.Add(bracket);
            }
            else
            {
                lblError.Visible = true;
                return;
            }

            DatabaseManager.context.Tournaments.Add(tournament);
            DatabaseManager.Save();

            this.Close();
            menu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void TournamentCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbTeamSelection.Items.Clear();
            lbTeamFinal.Items.Clear();
            cbTournamentType.SelectedIndex = -1;
            tbTournamentName.Text = string.Empty;
        }
    }
}
