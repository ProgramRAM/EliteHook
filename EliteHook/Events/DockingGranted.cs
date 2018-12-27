using System;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class DockingGranted
    {
        internal static void EliteAPI_DockingGrantedEvent(object sender, DockingGrantedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("About to dock");
            embed.WithTitle($"Allowed docking at {e.StationName}");
            embed.WithDescription($"In {Program.EliteAPI.lastStation.System}" + Environment.NewLine +
                $"Landing pad {e.LandingPad}");

            Program.Send(embed);
        }
    }
}
