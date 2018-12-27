using System;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal class USSDrop
    {
        internal static void USSDropEvent(object sender, USSDropInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Dropped out to an USS");
            embed.WithTitle("USS information");
            embed.WithDescription($"{e.USSType_Localised}, level {e.USSThreat}");

            Program.Send(embed);
        }
    }
}