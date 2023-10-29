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
        public TeamViewEditForm(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
            teams = DatabaseManager.context.Teams.ToList();
            players = new List<Player>();
        }

        private void TeamViewEditForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in teams)
            {
                cbTeams.Items.Add(team);
            }
            lblTeamName.Visible = false;
            lblPlayers.Visible = false;
            lblPlayerInfo.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbTeams.SelectedItem is Team team)
            {
                // Make the correct labels visible and add the team details
                lblTeamName.Visible = true;
                lblTeamName.Text = team.Name;
                lblPlayers.Visible = true;
                lblPlayerInfo.Visible = true;
                btnView.BackColor = SystemColors.ControlDark;
                btnEdit.BackColor = SystemColors.Control;
                players = team.GetPlayers();
                foreach (Player player in players)
                {
                    // Appends the name and email for each player
                    lblPlayers.Text += String.Format("{0} - {1}\r\n", player.Name, player.Email);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
