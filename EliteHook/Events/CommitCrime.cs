using System;

using Discord;

using EliteAPI.Events;

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
                $"Fine: {string.Format("{0:n0}", e.Bounty)} CR");

            Main.Send(embed);
        }
    }
}
