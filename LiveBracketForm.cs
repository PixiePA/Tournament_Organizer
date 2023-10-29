using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            List<Match> initialMatches = currentTournament.Bracket.AllMatchesInRound(currentTournament.Bracket.CurrentRound);
            int numOfMatches = initialMatches.Count;
            if (numOfMatches == 8)
            {
                numOfMatches = 8;
                for (int i = 0; i <= 16; i += 2)
                {
                    Control control = Controls.Find("row4box" + i, true).FirstOrDefault();
                    control.Text = initialMatches[i].TeamA().Name;
                    control.Visible = true;
                }
                for (int i = 1; i <= 16; i += 2)
                {
                    Control control = Controls.Find("row4box" + i, true).FirstOrDefault();
                    control.Text = initialMatches[i].TeamB().Name;
                    control.Visible = true;
                }
            }
            else if (numOfMatches == 4)
            {
                numOfMatches = 4;
                for (int i = 0; i <= 8; i += 2)
                {
                    Control control = this.Controls.Find("row3box" + i, true).FirstOrDefault();
                    control.Text = initialMatches[i].TeamA().Name;
                    control.Visible = true;
                }
                for (int i = 1; i <= 8; i += 2)
                {
                    Control control = this.Controls.Find("row3box" + i, true).FirstOrDefault();
                    control.Text = initialMatches[i].TeamB().Name;
                    control.Visible = true;
                }

            }
            else if (numOfMatches == 2)
            {
                numOfMatches = 2;
                row2box1.Text = initialMatches[0].TeamA().Name;
                row2box1.Visible = true;
                row2box2.Text = initialMatches[0].TeamB().Name;
                row2box2.Visible = true;
                row2box3.Text = initialMatches[1].TeamA().Name;
                row2box3.Visible = true;
                row2box4.Text = initialMatches[1].TeamB().Name;
                row2box4.Visible = true;
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
                    row3box1.Text = matchesInRound[0].TeamA().Name;
                    row3box2.Text = matchesInRound[0].TeamB().Name;
                    row3box3.Text = matchesInRound[1].TeamA().Name;
                    row3box4.Text = matchesInRound[1].TeamB().Name;
                    row3box5.Text = matchesInRound[2].TeamA().Name;
                    row3box6.Text = matchesInRound[2].TeamB().Name;
                    row3box7.Text = matchesInRound[3].TeamA().Name;
                    row3box8.Text = matchesInRound[3].TeamB().Name;
                }
                else if (round == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row2box1.Text = matchesInRound[0].TeamA().Name;
                    row2box2.Text = matchesInRound[0].TeamB().Name;
                    row2box3.Text = matchesInRound[1].TeamA().Name;
                    row2box4.Text = matchesInRound[1].TeamB().Name;
                }
                else if (round == 4)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;

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
                    row2box1.Text = matchesInRound[0].TeamA().Name;
                    row2box2.Text = matchesInRound[0].TeamB().Name;
                    row2box3.Text = matchesInRound[1].TeamA().Name;
                    row2box4.Text = matchesInRound[1].TeamB().Name;
                }
                else if (round == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;

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
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int round = currentTournament.Bracket.CurrentRound;
            List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
            foreach (Match match in matchesInRound)
            {
                if (!match.IsMatchOver())
                {
                    this.Hide();
                    MinigameForm mForm = new MinigameForm(match);
                    mForm.Show();
                    break;
                }
            }

        }
    }
}
