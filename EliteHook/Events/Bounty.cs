using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    public static class Bounty
    {
        internal static void EliteAPI_BountyEvent(object sender, BountyInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithAuthor("Recieved a bounty");
            embed.WithTitle("Bounty information");
            embed.WithDescription($"Total: {string.Format("{0:n0}", e.TotalReward)} CR");
            foreach (var item in e.Rewards)
            {
                embed.AddField(item.Faction, $"{string.Format("{0:n0}", item.Reward)} CR", true);
            }

            Program.Send(embed);
        }
    }
}
