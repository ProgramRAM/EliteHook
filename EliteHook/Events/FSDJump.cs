using System;

using EliteAPI;

using Discord;
using EliteAPI.Events;

namespace EliteHook.Events
{
    public static class FSDJump
    {
        internal static void EliteAPI_FSDJumpEvent(object sender, FSDJumpInfo e)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithTitle($"Jumping to {e.StarSystem}");
            embed.AddField("System information",
                $"Pledge: {e.SystemAllegiance}" + Environment.NewLine +
                $"Politics: {e.SystemGovernmentLocalised}" + Environment.NewLine +
                $"Safety: {e.SystemSecurityLocalised}" + Environment.NewLine +
                $"Economy: {e.SystemEconomyLocalised} and {e.SystemSecondEconomyLocalised}" + Environment.NewLine
                //$"Faction: {Program.EliteAPI.lastSystem.SystemFaction}" + Environment.NewLine, true);
                , true);

            embed.AddField("Jump information",
                $"Distance: {Math.Round(e.JumpDist, 1)} ly" + Environment.NewLine +
                $"Fuel used: {Math.Round(e.FuelUsed, 1)} tonnes" + Environment.NewLine +
                $"Fuel left: {Math.Round(e.FuelLevel, 1)} tonnes" + Environment.NewLine 
                //Scoopable(Program.EliteAPI.lastSystem.Class) + Environment.NewLine, true);
                , true);

            Main.Send(embed);
        }

        private static string Scoopable(string classChar) {
            switch (classChar.ToLower())
            {
                case "k":
                case "g":
                case "b":
                case "f":
                case "o":
                case "a":
                case "m":
                    return "Star is scoopable";

                default:
                    return "Star is not scoopable";
            }
        }
    }
}
