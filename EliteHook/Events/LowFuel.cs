
using Discord;

namespace EliteHook.Events
{
    internal static class Lowfuel
    {
        internal static void EliteAPI_LowFuelEvent(object sender, bool e)
        {
            EmbedBuilder embed = new EmbedBuilder();

            embed.AddField("Low on fuel!", "Better start to scoop soon ...");

            Main.Send(embed);
        }
    }
}
