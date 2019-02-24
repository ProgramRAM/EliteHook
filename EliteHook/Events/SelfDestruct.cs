using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class SelfDestruct
    {
        internal static void EliteAPI_SelfDestructEvent(object sender, SelfDestructInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Is self-destructing");
            embed.WithTitle("Self-destructing");
            embed.WithDescription(":( rip");

            Main.Send(embed);
            
        }
    }
}
