using System;

using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    public static class Docked
    {
        internal static void EliteAPI_DockedEvent(object sender, DockedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Touched down");
            embed.WithTitle($"Docked at {e.StationName}");
            embed.AddField("Station information", $"System: {e.StarSystem}" + Environment.NewLine +
                $"Distance: {string.Format("{0:n0}", Math.Round(e.DistFromStarLs))} ls" + Environment.NewLine +
                $"Pleged to: {e.StationAllegiance}" + Environment.NewLine +
                $"Politics: {e.StationGovernmentLocalised}" + Environment.NewLine +
                $"Faction: {e.StationFaction.Name}" + Environment.NewLine +
                $"Economy: {e.StationEconomyLocalised}", true);

            Main.Send(embed);
        }
    }
}
