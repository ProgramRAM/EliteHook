using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    internal class USSDrop
    {
        internal static void USSDropEvent(object sender, USSDropInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Dropped out to an USS");
            embed.WithTitle("USS information");
            embed.WithDescription($"{e.UssTypeLocalised}, level {e.UssThreat}");

            Main.Send(embed);
        }
    }
}