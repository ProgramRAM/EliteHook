using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class Died
    {
        internal static void EliteAPI_DiedEvent(object sender, DiedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithTitle("Died");
            embed.WithDescription("rip :(");

            Program.Send(embed);
            
        }
    }
}
