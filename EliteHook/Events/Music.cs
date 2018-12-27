using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class Music
    {
        internal static void EliteAPI_MusicEvent(object sender, MusicInfo e)
        {
            switch(e.MusicTrack.ToLower())
            {
                case "mainmenu":
                    EmbedBuilder embed = new EmbedBuilder();
                    embed.WithTitle("In the main menu");
                    Program.Send(embed);
                    break;

                case "autopilot":
                    EmbedBuilder embed2 = new EmbedBuilder();
                    embed2.WithDescription("Using autopilot");
                    embed2.WithTitle($"To dock at {Program.EliteAPI.lastStation.Name}");
                    embed2.WithDescription($"In {Program.EliteAPI.lastSystem.Name}");
                    Program.Send(embed2);
                    break;
            }


        }
    }
}
