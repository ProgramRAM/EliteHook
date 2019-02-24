using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class MarketBuy
    {
        internal static void EliteAPI_MarketBuyEvent(object sender, MarketBuyInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("Buying goods");
            embed.WithTitle($"Bought {e.TypeLocalised}");
            embed.WithDescription($"{e.Count} for {string.Format("{0:n0}", e.TotalCost)} CR" + Environment.NewLine +
                $"From {Main.EliteAPI.Location.Station} in {Main.EliteAPI.Location.Station}");

            Main.Send(embed);
        }
    }
}
