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
    public partial class TournamentCreationForm : Form
    {

        public TournamentCreationForm()
        {
            InitializeComponent();
        }

        // Add the teams selected in the list box
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var team in lbTeamSelection.SelectedItems)
            {
                // Check that the team being added isn't already there and that there's still under 16 teams
                if (!lbTeamFinal.Items.Contains(team) && lbTeamFinal.Items.Count < 16)
                {
                    lbTeamFinal.Items.Add(team);
                }
            }

            // Validate tournament size
            TeamValidation();
        }

        // Remove teams selected when remove button is clicked
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var team in lbTeamSelection.SelectedItems)
            {
                lbTeamFinal.Items.Remove(team);
            }

            // Validate tournament size
            TeamValidation();
        }

        // Validate the number of teams
        private void TeamValidation()
        {
            // Check amount of teams selected
            if (lbTeamFinal.Items.Count != 4 || lbTeamFinal.Items.Count != 8 || lbTeamFinal.Items.Count != 12 || lbTeamFinal.Items.Count != 16)
            {
                lblError.Visible = true;
                btnSubmit.Visible = false;
                return;
            }

            // Display submit button and hide error message if there is a valid amount of teams
            lblError.Visible = false;
            btnSubmit.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create tournament with tournament name, type and teams selected
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Load main menu and close form
            Form1 menu = new Form1();
            menu.ShowDialog();
            Close();
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
