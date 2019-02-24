using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class MarketSell
    {
        internal static void EliteAPI_MarketSellEvent(object sender, MarketSellInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor("Selling goods");
            embed.WithTitle($"Sold {e.TypeLocalised}");
            embed.WithDescription($"{e.Count} for {string.Format("{0:n0}", e.TotalSale)} CR" + Environment.NewLine +
                $"At {Main.EliteAPI.Location.Station} in {Main.EliteAPI.Location.Station}");

            Main.Send(embed);
        }
    }
}
