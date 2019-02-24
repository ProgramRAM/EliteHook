using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    internal static class Interdiction
    {
        internal static void EliteAPI_InterdictionEvent(object sender, InterdictionInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            if (e.Success) { embed.WithTitle($"Interdicted {e.Interdicted}"); }
            if (!e.Success) { embed.WithTitle($"Attempted to interdict {e.Interdicted}"); }

            Main.Send(embed);
        }
    }
}
