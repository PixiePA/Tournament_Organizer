﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey (nameof(IsAlpha), nameof(MatchID))]
    internal class MatchRegistration
    {
        private int teamID;
        private int matchID;
        private bool isAlpha;

        //Foreign key for player to be in match
        [ForeignKey(nameof(Player))]
        public int TeamID { get => teamID; set => teamID = value; }
        public Team Team { get; set; }

        [ForeignKey(nameof(Match))]
        public int MatchID { get => matchID; set => matchID = value; }
        public Match Match { get; set; }

        //Records if registration is in alpha or beta position for match
        public bool IsAlpha { get => isAlpha; set => isAlpha = value; }
    }
}
