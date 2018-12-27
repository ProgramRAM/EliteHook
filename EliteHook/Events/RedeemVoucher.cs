using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class RedeemVoucher
    {
        internal static void EliteAPI_RedeemVoucherEvent(object sender, RedeemVoucherInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Handed in vouchers");
            embed.WithTitle("Voucher information");
            embed.WithDescription($"Total: {string.Format("{0:n0}", e.Amount)} CR");
            foreach (var item in e.Factions)
            {
                embed.AddField(item.Faction, $"{string.Format("{0:n0}", item.Amount)} CR", true);
            }
                
            Program.Send(embed);
        }
    }
}
