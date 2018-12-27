using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class CommitCrime
    {
        internal static void EliteAPI_CommitCrimeEvent(object sender, CommitCrimeInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("Comitted a crime");
            embed.WithTitle("Crime information");
            embed.WithDescription($"Type: {e.CrimeType}" + Environment.NewLine +
                $"Faction: {e.Faction}" + Environment.NewLine +
                $"Fine: {string.Format("{0:n0}", e.Fine)} CR");

            Program.Send(embed);
        }
    }
}
