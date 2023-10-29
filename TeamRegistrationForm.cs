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
    internal partial class TeamRegistrationForm : Form
    {
        // Initialise number of players and the current button
        private int numOfPlayers;
        private Button currentBtn;
        private Form1 menu;

        public TeamRegistrationForm(Form1 menu)
        {
            InitializeComponent();
            currentBtn = btn4;
            numOfPlayers = 4;
            btn4.BackColor = SystemColors.ControlDark;
            this.menu = menu;
        }

        // Handle button clicks to display number of combo boxes and highlight buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            HandleButtons(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            HandleButtons(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            HandleButtons(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            HandleButtons(4);
        }

        private void HandleButtons(int btnNumber)
        {
            // Reset button colours each time one is clicked
            ResetButtons();

            // Change number of players depending on the button clicked and change colour of that button 
            numOfPlayers = btnNumber;
            currentBtn.BackColor = SystemColors.ControlDark;
            TogglePlayerSelect(btnNumber);
        }

        // Reset all button colours back to default
        private void ResetButtons()
        {
            btn1.BackColor = SystemColors.Control;
            btn2.BackColor = SystemColors.Control;
            btn3.BackColor = SystemColors.Control;
            btn4.BackColor = SystemColors.Control;
        }

        // Toggle visibility of player selection combo boxes
        private void TogglePlayerSelect(int btnNumber)
        {
            // Reset all visible states of the player number buttons and labels
            cbPlayer1.Visible = false;
            lblPlayer1.Visible = false;
            cbPlayer2.Visible = false;
            lblPlayer2.Visible = false;
            cbPlayer3.Visible = false;
            lblPlayer3.Visible = false;
            cbPlayer4.Visible = false;
            lblPlayer4.Visible = false;
                
            // Check that comboboxes aren't null and toggle visibility on all player choice boxes up to the btn number
            for (int i = 1; i <= btnNumber; i++)
            {
                if (Controls.Find("cbPlayer" + i, true).FirstOrDefault() is ComboBox cb && Controls.Find("lblPlayer" + (i), true).FirstOrDefault() is Label lbl)
                {
                    cb.Visible = true;
                    lbl.Visible = true;
                }
            }
        }

        // Show an error message and hide the confirm button if any players selected are the same
        private void PlayerDuplicates()
        {
            // List to store player IDs to compare for duplicates
            List<int> selectedPlayerIDs = new List<int>();

            // Find each player select combobox depending on the number of players
            for (int i = 1; i <= numOfPlayers; i++)
            {
                // Check the names aren't null and players selected aren't null
                if (Controls.Find("cbPlayer" + i, true).FirstOrDefault() is ComboBox cb && cb.Visible)
                {
                    if (cb.SelectedItem is Player selectedPlayer)
                    {
                        int playerID = selectedPlayer.PlayerID;

                        // Check if player is already selected and display error/button depending on the result
                        if (selectedPlayerIDs.Contains(playerID))
                        {
                            lblError.Text = "You can't select the same player more than once";
                            lblError.Visible = true;
                            btnSubmit.Visible = false;
                            return;
                        }
                        // Add the player to the list for next comparison
                        selectedPlayerIDs.Add(playerID);
                    }
                }
            }

            // Display submit button and hide error message if all players are different
            lblError.Visible = false;
            btnSubmit.Visible = true;
        }

        // Show and hide error message as well as the confirm button whenever a new player is selected
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerDuplicates();
        }

        // Create a new team based on the number of players selected, or show an error message
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create team with the players selected and add the team to the database
            //
            switch(numOfPlayers)
            {
                case 1:
                    if(tbTeamName.Text.Length > 0 && cbPlayer1.SelectedIndex != -1)
                    {
                        Team team = new Team(tbTeamName.Text);
                        team.RegisterToTeam(cbPlayer1.SelectedItem as Player);
                        DatabaseManager.context.Teams.Add(team);
                        DatabaseManager.Save();

                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                        lblError.Text = "You must have a team name and select a player in all dropdown boxes available.";
                        lblError.Visible = true;
                    }
                    break;
                case 2:
                    if (tbTeamName.Text.Length > 0 && cbPlayer1.SelectedIndex != -1 && cbPlayer2.SelectedIndex != -1)
                    {
                        Team team = new Team(tbTeamName.Text);
                        team.RegisterToTeam(cbPlayer1.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer2.SelectedItem as Player);
                        DatabaseManager.context.Teams.Add(team);
                        DatabaseManager.Save();

                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                        lblError.Text = "You must have a team name and select a player in all dropdown boxes available.";
                        lblError.Visible = true;
                    }
                    break;
                case 3:
                    if (tbTeamName.Text.Length > 0 && cbPlayer1.SelectedIndex != -1 && cbPlayer2.SelectedIndex != -1 && cbPlayer3.SelectedIndex != -1)
                    {
                        Team team = new Team(tbTeamName.Text);
                        team.RegisterToTeam(cbPlayer1.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer2.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer3.SelectedItem as Player);
                        DatabaseManager.context.Teams.Add(team);
                        DatabaseManager.Save();

                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                        lblError.Text = "You must have a team name and select a player in all dropdown boxes available.";
                        lblError.Visible = true;
                    }
                    break;
                case 4:
                    if (tbTeamName.Text.Length > 0 && cbPlayer1.SelectedIndex != -1 && cbPlayer2.SelectedIndex != -1 && cbPlayer3.SelectedIndex != -1 && cbPlayer4.SelectedIndex != -1)
                    {
                        Team team = new Team(tbTeamName.Text);
                        team.RegisterToTeam(cbPlayer1.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer2.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer3.SelectedItem as Player);
                        team.RegisterToTeam(cbPlayer4.SelectedItem as Player);
                        DatabaseManager.context.Teams.Add(team);
                        DatabaseManager.Save();

                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                        lblError.Text = "You must have a team name and select a player in all dropdown boxes available.";
                        lblError.Visible = true;
                    }
                    break;
                default:
                    lblError.Text = "You must have a team name and select a player in all dropdown boxes available.";
                    lblError.Visible = true;
                    break;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void TeamRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetButtons();
            tbTeamName.Text = string.Empty;
            cbPlayer1.SelectedIndex = -1;
            cbPlayer2.SelectedIndex = -1;
            cbPlayer3.SelectedIndex = -1;
            cbPlayer4.SelectedIndex = -1;
        }
    }
}
