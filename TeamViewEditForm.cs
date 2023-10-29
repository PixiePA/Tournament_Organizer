using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Tracker
{
    public partial class TeamViewEditForm : Form
    {
        private Form1 menu;
        private List<Team> teams;
        private List<Player> players;
        private List<Player> currentPlayers;
        public TeamViewEditForm(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
            teams = DatabaseManager.context.Teams.ToList();
            players = DatabaseManager.context.Players.ToList();
        }

        private void TeamViewEditForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in teams)
            {
                cbTeams.Items.Add(team);
            }
            foreach (Player player in players)
            {
                lbAllPlayers.Items.Add(player);
            }
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeams.SelectedItem is Team team)
            {
                // Make the correct controls visible
                lblTeamName.Visible = true;
                lblPlayers.Visible = true;
                lblAllPlayers.Visible = true;
                lblChooseTeam.Visible = true;
                lblArrow.Visible = true;
                tbName.Visible = true;
                lbAllPlayers.Visible = true;
                lbPlayers.Visible = true;
                btnAdd.Visible = true;
                btnCancel.Visible = true;

                // Add team's name, clear players and add new team's players
                tbName.Text = team.Name;
                lbPlayers.Items.Clear();
                currentPlayers = team.GetPlayers();

                foreach (Player player in currentPlayers)
                {
                    lbPlayers.Items.Add(player);
                }
            }
        }

        // Save new name and close window
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTeams.SelectedItem is Team team)
            {
                if (team.Name != tbName.Text)
                {
                    team.Name = tbName.Text;
                }
            }

            this.Close();
            menu.Show();
        }

        // Cancel and exit
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        // Clean up on exit
        private void TeamViewEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lblTeamName.Visible = false;
            lblPlayers.Visible = false;
            lblAllPlayers.Visible = false;
            lblChooseTeam.Visible = false;
            lblArrow.Visible = false;
            tbName.Visible = false;
            lbAllPlayers.Visible = false;
            lbPlayers.Visible = false;
            btnAdd.Visible = false;
            btnCancel.Visible = false;
        }

        // If there is space and there is a selected team, add the player to the team if they're not already there.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check selected item is a team and players item count is less than 4
            if (cbTeams.SelectedItem is Team team && lbPlayers.Items.Count < 4)
            {
                // Check that player selected isn't null
                if (lbAllPlayers.SelectedItem is Player newPlayer)
                {
                    // Check that player doesn't already exist
                    if (!lbPlayers.Items.Contains(newPlayer))
                    {
                        // Register the new player to the team and add to the current players list box
                        team.RegisterToTeam(newPlayer);
                        lbPlayers.Items.Add(newPlayer);
                    }
                }

            }
        }
    }
}
