using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(BracketID))]
    internal class LosersBracket : Bracket
    {
        private int winnersBracketID;

        [ForeignKey(nameof(WinnersBracket))]
        public int WinnersBracketID { get => winnersBracketID; set => winnersBracketID = value; }

        public Bracket WinnersBracket { get; set; }


    }
}
