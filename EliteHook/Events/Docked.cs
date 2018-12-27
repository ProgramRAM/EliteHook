using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

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
                $"Distance: {string.Format("{0:n0}", Math.Round(e.DistFromStarLS))} ls" + Environment.NewLine +
                $"Pleged to: {e.StationAllegiance}" + Environment.NewLine +
                $"Politics: {e.StationGovernment_Localised}" + Environment.NewLine +
                $"Faction: {e.StationFaction} ({e.FactionState})" + Environment.NewLine +
                $"Economy: {e.StationEconomy_Localised}", true);

            Program.Send(embed);
        }
    }
}
