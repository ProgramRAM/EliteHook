using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class MaterialCollected
    {
        internal static void EliteAPI_MaterialCollectedEvent(object sender, MaterialCollectedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("Stumbled upon materials");
            embed.WithTitle($"Found {e.Count} {e.Name}");

            Main.Send(embed);
        }
    }
}
