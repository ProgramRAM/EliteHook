using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public class DockingDenied
    {
        internal static void EliteAPI_DockingDeniedEvent(object sender, DockingDeniedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Got denied docking");
            embed.WithTitle($"Not allowed to dock at {e.StationName}");
            embed.WithDescription($"Reason: {e.Reason}");

            Program.Send(embed);
        }
    }
}
