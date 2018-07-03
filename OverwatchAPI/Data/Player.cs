﻿using System.Collections.Generic;
using OverwatchAPI.Data;

namespace OverwatchAPI
{
    public sealed class Player
    {
        public string Username { get; set; }
        internal string UsernameUrlFriendly => Username.BattletagToUrlFriendlyString();
        public Platform Platform { get; set; }
        public string ProfileUrl { get; set; }
        public ushort PlayerLevel { get; set; }
        public string PlayerLevelImage { get; set; }
        public ushort CompetitiveRank { get; set; }
        public ushort EndorsementLevel { get; set; }
        /// <summary>
        /// If the players profile is private - No stats will be available.
        /// </summary>
        public bool IsProfilePrivate { get; set; }
        public List<Stat> CasualStats { get; set; }
        public List<Stat> CompetitiveStats { get; set; }
        public List<Stat> Endorsements { get; set; }
        public List<Achievement> Achievements { get; set; }
        public string CompetitiveRankImageUrl { get; set; }
        public string ProfilePortraitUrl { get; set; }
    }
}
