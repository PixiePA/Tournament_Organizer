﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(PlayerID), nameof(TeamID))]
    public class TeamRegistration
    {
        private int playerID;
        private int teamID;

        [ForeignKey(nameof(Player))]
        [Required]
        public int PlayerID { get => playerID; set => playerID = value; }

        [ForeignKey(nameof(Team))]
        [Required]
        public int TeamID { get => teamID; set => teamID = value; }

        public Player Player { get; set; }

        public Team Team { get; set; }
    }
}
