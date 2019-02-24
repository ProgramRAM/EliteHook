using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    public class DockingDenied
    {
        internal static void EliteAPI_DockingDeniedEvent(object sender, DockingDeniedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Got denied docking");
            embed.WithTitle($"Not allowed to dock at {e.StationName}");
            embed.WithDescription($"Reason: {e.Reason}");

            Main.Send(embed);
        }
    }
}
