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
        private int numberOfMatches = 0;
        public LiveBracketForm(Tournament currentTournament)
        {
            InitializeComponent();
            this.currentTournament = currentTournament;
            LoadMatches();
        }

        private void LoadMatches()
        {
            List<Match> initialMatches = currentTournament.Bracket.Matches.ToList();
            int numOfMatches = initialMatches.Count;
            if (numOfMatches == 8)
            {
                numOfMatches = 8;
                row4box1.Text = initialMatches[0].TeamA.Name;
                row4box2.Text = initialMatches[0].TeamB.Name;
                row4box3.Text = initialMatches[1].TeamA.Name;
                row4box4.Text = initialMatches[1].TeamB.Name;
                row4box5.Text = initialMatches[2].TeamA.Name;
                row4box6.Text = initialMatches[2].TeamB.Name;
                row4box7.Text = initialMatches[3].TeamA.Name;
                row4box8.Text = initialMatches[3].TeamB.Name;
                row4box9.Text = initialMatches[4].TeamA.Name;
                row4box10.Text = initialMatches[4].TeamB.Name;
                row4box11.Text = initialMatches[5].TeamA.Name;
                row4box12.Text = initialMatches[5].TeamB.Name;
                row4box13.Text = initialMatches[6].TeamA.Name;
                row4box14.Text = initialMatches[6].TeamB.Name;
                row4box15.Text = initialMatches[7].TeamA.Name;
                row4box16.Text = initialMatches[7].TeamB.Name;
            }
            else if (numOfMatches == 4)
            {
                numOfMatches = 4;
                row3box1.Text = initialMatches[0].TeamA.Name;
                row3box2.Text = initialMatches[0].TeamB.Name;
                row3box3.Text = initialMatches[1].TeamA.Name;
                row3box4.Text = initialMatches[1].TeamB.Name;
                row3box5.Text = initialMatches[2].TeamA.Name;
                row3box6.Text = initialMatches[2].TeamB.Name;
                row3box7.Text = initialMatches[3].TeamA.Name;
                row3box8.Text = initialMatches[3].TeamB.Name;

            }
            else if (numOfMatches == 2)
            {
                numOfMatches = 2;
                row2box1.Text = initialMatches[0].TeamA.Name;
                row2box2.Text = initialMatches[0].TeamB.Name;
                row2box3.Text = initialMatches[1].TeamA.Name;
                row2box4.Text = initialMatches[1].TeamB.Name;
            }
        }

        private void UpdateLiveBracket()
        {
            int round = currentTournament.Bracket.CurrentRound;
            if (numberOfMatches == 8)
            {
                if (round == 1)
                {
                    LoadMatches();
                }
                else if (round == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row3box1.Text = matchesInRound[0].TeamA.Name;
                    row3box2.Text = matchesInRound[0].TeamB.Name;
                    row3box3.Text = matchesInRound[1].TeamA.Name;
                    row3box4.Text = matchesInRound[1].TeamB.Name;
                    row3box5.Text = matchesInRound[2].TeamA.Name;
                    row3box6.Text = matchesInRound[2].TeamB.Name;
                    row3box7.Text = matchesInRound[3].TeamA.Name;
                    row3box8.Text = matchesInRound[3].TeamB.Name;
                }
                else if (round == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row2box1.Text = matchesInRound[0].TeamA.Name;
                    row2box2.Text = matchesInRound[0].TeamB.Name;
                    row2box3.Text = matchesInRound[1].TeamA.Name;
                    row2box4.Text = matchesInRound[1].TeamB.Name;
                }
                else if (round == 4)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row1box1.Text = matchesInRound[0].TeamA.Name;
                    row1box2.Text = matchesInRound[0].TeamB.Name;

                }
            }
            if (numberOfMatches == 4)
            {
                if (round == 1)
                {
                    LoadMatches();
                }
                else if (round == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row2box1.Text = matchesInRound[0].TeamA.Name;
                    row2box2.Text = matchesInRound[0].TeamB.Name;
                    row2box3.Text = matchesInRound[1].TeamA.Name;
                    row2box4.Text = matchesInRound[1].TeamB.Name;
                }
                else if (round == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row1box1.Text = matchesInRound[0].TeamA.Name;
                    row1box2.Text = matchesInRound[0].TeamB.Name;

                }
            }
            if (numberOfMatches == 2)
            {
                if (round == 1)
                {
                    LoadMatches();
                }
                else if (round == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row1box1.Text = matchesInRound[0].TeamA.Name;
                    row1box2.Text = matchesInRound[0].TeamB.Name;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int round = currentTournament.Bracket.CurrentRound;
            List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
            foreach (Match _match in matchesInRound)
            {
                if (_match.IsMatchOver())
                {
                    continue;
                }
                else
                {
                    MinigameForm nForm = new MinigameForm(_match);
                    break;
                }
            }

        }
    }
}
