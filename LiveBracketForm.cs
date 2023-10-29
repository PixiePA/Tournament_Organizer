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
        private int currentRound = 1;
        public LiveBracketForm(Tournament currentTournament)
        {
            InitializeComponent();
            this.currentTournament = currentTournament;
            LoadMatches();
        }

        private void LoadMatches()
        {
            List<Match> initialMatches = currentTournament.Bracket.AllMatchesInRound(1);
            numberOfMatches = initialMatches.Count;
            if (numberOfMatches == 8)
            {
                numberOfMatches = 8;
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
            else if (numberOfMatches == 4)
            {
                numberOfMatches = 4;
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
            else if (numberOfMatches == 2)
            {
                numberOfMatches = 2;
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
            currentRound = currentTournament.Bracket.CurrentRound;
            if (numberOfMatches == 8)
            {
                if (currentRound == 1)
                {
                    LoadMatches();
                }
                else if (currentRound == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row3box1.Text = matchesInRound[0].TeamA().Name;
                    row3box2.Text = matchesInRound[0].TeamB().Name;
                    row3box3.Text = matchesInRound[1].TeamA().Name;
                    row3box4.Text = matchesInRound[1].TeamB().Name;
                    row3box5.Text = matchesInRound[2].TeamA().Name;
                    row3box6.Text = matchesInRound[2].TeamB().Name;
                    row3box7.Text = matchesInRound[3].TeamA().Name;
                    row3box8.Text = matchesInRound[3].TeamB().Name;
                }
                else if (currentRound == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row2box1.Text = matchesInRound[0].TeamA().Name;
                    row2box2.Text = matchesInRound[0].TeamB().Name;
                    row2box3.Text = matchesInRound[1].TeamA().Name;
                    row2box4.Text = matchesInRound[1].TeamB().Name;
                }
                else if (currentRound == 4)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;

                }
            }
            if (numberOfMatches == 4)
            {
                if (currentRound == 1)
                {
                    LoadMatches();
                }
                else if (currentRound == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row2box1.Text = matchesInRound[0].TeamA().Name;
                    row2box2.Text = matchesInRound[0].TeamB().Name;
                    row2box3.Text = matchesInRound[1].TeamA().Name;
                    row2box4.Text = matchesInRound[1].TeamB().Name;
                }
                else if (currentRound == 3)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;

                }
            }
            if (numberOfMatches == 2)
            {
                if (currentRound == 1)
                {
                    LoadMatches();
                }
                else if (currentRound == 2)
                {
                    List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(currentRound);
                    row1box1.Text = matchesInRound[0].TeamA().Name;
                    row1box2.Text = matchesInRound[0].TeamB().Name;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayMatch();

        }

        private void PlayMatch()
        {
            int round = currentTournament.Bracket.CurrentRound;
            List<Match> matchesInRound = currentTournament.Bracket.AllMatchesInRound(round);
            foreach (Match match in matchesInRound)
            {
                if (!match.IsMatchOver())
                {
                    this.Close();
                    MinigameForm mForm = new MinigameForm(match, currentTournament);
                    mForm.Show();
                    break;
                }

            }


        }

        private void LiveBracketForm_Activated(object sender, EventArgs e)
        {
            UpdateLiveBracket();
        }
    }
}
