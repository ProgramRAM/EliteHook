using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class Undocked
    {
        internal static void EliteAPI_UndockedEvent(object sender, UndockedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Lifting off");
            embed.WithTitle($"Undocked from {e.StationName}");
            embed.WithDescription($"In {Main.EliteAPI.Location.StarSystem}");

            Main.Send(embed);
        }
    }
}
