using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class SupercruiseEntry
    {
        internal static void EliteAPI_SupercruiseEntryEvent(object sender, SupercruiseEntryInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor($"Entered supercruise");
            embed.WithTitle("Location information");
            embed.WithDescription($"In {e.StarSystem}");

            Main.Send(embed);
        }
    }
}
