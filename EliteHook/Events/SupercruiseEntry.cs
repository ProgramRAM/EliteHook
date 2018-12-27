using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Program.Send(embed);
        }
    }
}
