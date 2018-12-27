using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class CollectCargo
    {
        internal static void EliteAPI_CollectCargoEvent(object sender, CollectCargoInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("Collected cargo");
            embed.WithTitle("Cargo information");
            embed.WithDescription($"Collected {Stolen(e.Stolen)} {e.Type_Localised}");

            Program.Send(embed);
        }

        private static string Stolen(bool stolen)
        {
            if (stolen) { return "stolen"; } else return ""; 
        }
    }
}
