using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class SupercruiseExit
    {
        internal static void EliteAPI_SupercruiseExitEvent(object sender, SupercruiseExitInfo e)
        {
            Console.WriteLine(e.BodyType);

            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor($"Exited supercruise");
            embed.WithTitle("Location information");
            embed.WithDescription($"Near {e.BodyType.ToLower().Replace("planetaryring", "the rings of").Replace(e.StarSystem.ToLower(), "")} {e.Body.Replace("Ring", "")} in {e.StarSystem}");

            Program.Send(embed);
        }
    }
}
