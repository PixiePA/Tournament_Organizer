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
    public partial class MinigameForm : Form
    {
        Player player1;
        Player player2;
        public MinigameForm(Match match)
        {
            InitializeComponent();

            LoadTeam(match.TeamA, lbTeam1Players);
            LoadTeam(match.TeamB, lbTeam1Players);

            LoadMatch();
        }

        // Load team and their players into the list boxes
        private void LoadTeam(Team team, ListBox listBox)
        {
            List<Player> players = team.GetPlayers();

            foreach (Player player in players)
            {
                listBox.Items.Add(player);
            }
        }

        private void LoadMatch()
        {
            // Load first players in the list
            player1 = (Player)lbTeam1Players.Items[0];
            player2 = (Player)lbTeam2Players.Items[0];

            // Show who's playing who
            lblCurrentPlayers.Text = String.Format("{0} vs {1}", player1.Name, player2.Name);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Create a new random object and give it a 50/50 chance of being a crown or star
            Random random = new Random();
            string winner = (random.Next(2) == 0) ? "coin_crown" : "coin_star";

            // Set the game coin as the winning coin
            pbCoinCurrent.Image = Properties.Resources.ResourceManager.GetObject(winner) as Image;

            // Announce winner, remove loser from the round and load the next match if there are still players
            if (winner == "coin_crown")
            {
                // Player 1 wins
                lblWinner.Text = player1.Name + " Won That Round!";
                lbTeam2Players.Items.RemoveAt(0);

                // Check if there are any players left of team 2
                if (lbTeam2Players.Items.Count == 0)
                {
                    // If Team 1 has won then announce winner and show continue button
                    lblWinner.Text = String.Format("{0} has won!!! {1} has been eliminated :(", lblTeam1Name.Text, lblTeam2Name.Text);
                    btnPlay.Visible = false;
                    btnAutoPlay.Visible = false;
                    btnContinue.Visible = true;
                }
                else
                {
                    LoadMatch();
                }
            }
            else
            {
                // Player 2 wins
                lblWinner.Text = player2.Name + " Won That Round!";
                lbTeam1Players.Items.RemoveAt(0);

                // Check if there are any players left of team 1
                if (lbTeam1Players.Items.Count == 0)
                {
                    // If Team 2 has won then announce winner and show continue button
                    lblWinner.Text = String.Format("{0} has won!!! {1} has been eliminated :(", lblTeam2Name.Text, lblTeam1Name.Text);
                    btnPlay.Visible = false;
                    btnAutoPlay.Visible = false;
                    btnContinue.Visible = true;
                }
                else
                {
                    LoadMatch();
                }
            }


        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void MinigameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnPlay.Visible = true;
            btnAutoPlay.Visible = true;
            btnContinue.Visible = false;
            lblWinner.Visible = false;
            lbTeam1Players.Items.Clear();
            lbTeam2Players.Items.Clear();
        }
    }
}
