using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
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
            embed.WithDescription($"Near {Main.EliteAPI.Location.BodyType.ToLower().Replace("planetaryring", "the rings of").Replace(Main.EliteAPI.Location.Station.ToLower(), "")} {Main.EliteAPI.Location.Body.Replace("Ring", "")} in {Main.EliteAPI.Location.Station}");

            Main.Send(embed);
        }
    }
}
