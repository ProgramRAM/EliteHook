using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class Undocked
    {
        internal static void EliteAPI_UndockedEvent(object sender, UndockedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Lifting off");
            embed.WithTitle($"Undocked from {e.StationName}");
            embed.AddField("Station information", $"System: {Program.EliteAPI.lastSystem.Name}" + Environment.NewLine +
                $"Pleged to: {Program.EliteAPI.lastStation.Allegiance}" + Environment.NewLine +
                $"Politics: {Program.EliteAPI.lastStation.Government_Localised}" + Environment.NewLine +
                $"Faction: {Program.EliteAPI.lastStation.Faction} ({Program.EliteAPI.lastStation.FactionState})" + Environment.NewLine +
                $"Economy: {Program.EliteAPI.lastStation.Economy_Localised}", true);

            Program.Send(embed);
        }
    }
}
