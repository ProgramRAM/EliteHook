using Discord;

using EliteAPI.Events;

namespace EliteHook.Events
{
    public static class Died
    {
        internal static void EliteAPI_DiedEvent(object sender, DiedInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.WithTitle("Died");
            embed.WithDescription("rip :(");

            Main.Send(embed);
            
        }
    }
}
