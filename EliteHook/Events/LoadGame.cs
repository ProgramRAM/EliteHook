using System;

using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    internal static class LoadGame
    {
        internal static void EliteAPI_LoadGameEvent(object sender, LoadGameInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Loading up the game");
            embed.WithTitle("Game information");
            embed.WithDescription($"Mode: {e.GameMode}" + Environment.NewLine +
                $"Credits: {string.Format("{0:n0}", e.Credits)} CR" + Environment.NewLine +
                $"Ship: {e.Ship.Replace("Empire_Trader", "Imperial Clipper")} '{e.ShipName}' ({e.ShipIdent}) ");

            Main.Send(embed);
        }
    }
}
