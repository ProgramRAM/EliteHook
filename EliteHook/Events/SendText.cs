using Discord;

using EliteAPI;
using EliteAPI.Events;

namespace EliteHook.Events
{
    internal static class SendText
    {
        internal static void EliteAPI_SendTextEvent(object sender, SendTextInfo e)
        {
            if(e.Message.ToLower().StartsWith("@d"))
            {
                EmbedBuilder embed = new EmbedBuilder();

                embed.WithTitle("Message");
                embed.WithDescription(e.Message.Substring(2));

                
                Main.Send(embed);
            }
        }
    }
}
