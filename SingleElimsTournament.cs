using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class SingleElimsTournament : Tournament
    {
        public override TournamentType TournamentType { get=>TournamentType.SingleElims;}

        public override void PlaySets()
        {
            throw new NotImplementedException();
        }
    }
}
