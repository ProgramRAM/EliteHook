using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class Progress
    {
        internal static void EliteAPI_ProgressEvent(object sender, ProgressInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Loading up the game");
            embed.WithTitle("Ranks information");
            embed.AddField("Combat", $"{Combat(Main.EliteAPI.Commander.CombatRank)} ({e.Combat}%)", true);
            embed.AddField("Trade", $"{Combat(Main.EliteAPI.Commander.TradeRank)} ({e.Trade}%)", true);
            embed.AddField("Exploration", $"{Exploration(Main.EliteAPI.Commander.ExplorationRank)} ({e.Explore}%)", true);
            embed.AddField("Empire", $"{Empire(Main.EliteAPI.Commander.EmpireRank)} ({e.Empire}%)", true);
            embed.AddField("Federation", $"{Federation(Main.EliteAPI.Commander.FederationRank)} ({e.Federation}%)", true);

            Main.Send(embed);
        }

        private static string Empire(long x)
        {
            if(x == 0) { return "None"; }
            if(x == 1) { return "Outsider"; }
            if(x == 2) { return "Serf"; }
            if(x == 3) { return "Master"; }
            if(x == 4) { return "Squire"; }
            if(x == 5) { return "Knight"; }
            if(x == 6) { return "Lord"; }
            if(x == 7) { return "Baron"; }
            if(x == 8) { return "Viscount"; }
            if(x == 9) { return "Count"; }
            if(x == 10) { return "Earl"; }
            if(x == 11) { return "Marquis"; }
            if(x == 12) { return "Duke"; }
            if(x == 13) { return "Prince"; }
            if(x == 14) { return "King"; }
            return "";
        }

        private static string Federation(long x)
        {
            if (x == 0) { return "None"; }
            if (x == 1) { return "Recruit"; }
            if (x == 2) { return "Cadet"; }
            if (x == 3) { return "Midshipman"; }
            if (x == 4) { return "Petty Officer"; }
            if (x == 5) { return "Chief Petty Officer"; }
            if (x == 6) { return "Warrant Officer"; }
            if (x == 7) { return "Ensign"; }
            if (x == 8) { return "Lieutenant"; }
            if (x == 9) { return "Lieutenant Commander"; }
            if (x == 10) { return "Post Commander"; }
            if (x == 11) { return "Post Captain"; }
            if (x == 12) { return "Rear Admiral"; }
            if (x == 13) { return "Vice Admiral	"; }
            if (x == 14) { return "Admiral"; }
            return "";
        }

        private static string Combat(long x)
        {
            if (x == 0) { return "Harmless"; }
            if (x == 1) { return "Mostly Harmless"; }
            if (x == 2) { return "Novice"; }
            if (x == 3) { return "Competent"; }
            if (x == 4) { return "Expert"; }
            if (x == 5) { return "Master"; }
            if (x == 6) { return "Dangerous"; }
            if (x == 7) { return "Deadly"; }
            if (x == 8) { return "Elite"; }
            return "";
        }

        private static string Trade(long x)
        {
            if(x == 0) { return "Penniless"; }
            if(x == 1) { return "Mostly Penniless"; }
            if(x == 2) { return "Peddler"; }
            if(x == 3) { return "Dealer"; }
            if(x == 4) { return "Merchant"; }
            if(x == 5) { return "Broker"; }
            if(x == 6) { return "Entrepreneur"; }
            if(x == 7) { return "Tycoon"; }
            if(x == 8) { return "Elite"; }
            return "";
        }

        private static string Exploration(long x)
        {
            if (x == 0) { return "Aimless"; }
            if (x == 1) { return "Mostly Aimless"; }
            if (x == 2) { return "Scout"; }
            if (x == 3) { return "Surveyor"; }
            if (x == 4) { return "Trailblazer"; }
            if (x == 5) { return "Pathfinder"; }
            if (x == 6) { return "Ranger"; }
            if (x == 7) { return "Pioneer"; }
            if (x == 8) { return "Elite"; }
            return "";
        }
    }
}
