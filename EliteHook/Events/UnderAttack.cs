using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class UnderAttack
    {
        internal static void EliteAPI_UnderAttackEvent(object sender, UnderAttackInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Is under attack");
            embed.WithTitle("Combat information");
            embed.WithDescription($"Near {Program.EliteAPI.lastBody.Type.ToLower().Replace("planetaryring", "the rings of").Replace(Program.EliteAPI.lastSystem.Name.ToLower(), "")} {Program.EliteAPI.lastBody.Name.Replace("Ring", "")} in {Program.EliteAPI.lastSystem.Name}");

            Program.Send(embed);
        }
    }
}
