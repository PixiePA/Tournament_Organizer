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
    public partial class LiveBracketForm : Form
    {

        private Tournament currentTournament;
        public LiveBracketForm(Tournament currentTournament)
        {
            InitializeComponent();
            this.currentTournament = currentTournament;

            ////List of all teams that are participating in the tournament (can get either 4, 8 or 16 teams)
            ////get list of teams

            ////populate teams to form
            //numOfTeams = teams.len();
            //if (numOfTeams == 4)
            //{
            //    row2box1.Text = teams[0].name;
            //    row2box2.Text = teams[1].name;
            //    row2box3.Text = teams[2].name;
            //    row2box4.Text = teams[3].name;
            //}
            //else if (numOfTeams == 8)
            //{
            //    row3box1.Text = teams[0].name;
            //    row3box2.Text = teams[1].name;
            //    row3box3.Text = teams[2].name;
            //    row3box4.Text = teams[3].name;
            //    row3box5.Text = teams[4].name;
            //    row3box6.Text = teams[5].name;
            //    row3box7.Text = teams[6].name;
            //    row3box8.Text = teams[7].name;
            //}
            //else if (numOfTeams == 16)
            //{
            //    row4box1.Text = teams[0].name;
            //    row4box2.Text = teams[1].name;
            //    row4box3.Text = teams[2].name;
            //    row4box4.Text = teams[3].name;
            //    row4box5.Text = teams[4].name;
            //    row4box6.Text = teams[5].name;
            //    row4box7.Text = teams[6].name;
            //    row4box8.Text = teams[7].name;
            //    row4box9.Text = teams[8].name;
            //    row4box10.Text = teams[9].name;
            //    row4box11.Text = teams[10].name;
            //    row4box12.Text = teams[11].name;
            //    row4box13.Text = teams[12].name;
            //    row4box14.Text = teams[13].name;
            //    row4box15.Text = teams[14].name;
            //    row4box16.Text = teams[15].name;
            //}
            //else
            //{
            //    //error handling for too many players
            //}
        }

        private void LoadMatches(Match match)
        {

            Database.
            List<Match> initialMatches = Tournament.Bracket.Matches;
            len.matchesList; // to determine how many boxes are populated
           // List<Match> Matches


            //List<Player> players = team.GetPlayers();

            //foreach (Player player in players)
            //{
            //    listBox.Items.Add(player);
            //}

            //int round = Bracket.CurrentRound.Get;
            //List<Match> matches = Bracket.AllMatchesInRound(round);
            //List<Match> allMatchesInRound = matches;
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            //auto populate bracket with random winers

        }

        private void row4box1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
