using System;

using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    public static class DockingGranted
    {
        internal static void EliteAPI_DockingGrantedEvent(object sender, DockingGrantedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("About to dock");
            embed.WithTitle($"Allowed docking at {e.StationName}");
            embed.WithDescription($"In {Main.EliteAPI.Location.StarSystem}" + Environment.NewLine +
                $"Landing pad {e.LandingPad}");

            Main.Send(embed);
        }
    }
}
