using System;

using EliteAPI;

using Discord;

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
                $"Politics: {e.SystemGovernment_Localised}" + Environment.NewLine +
                $"Safety: {e.SystemSecurity_Localised}" + Environment.NewLine +
                $"Economy: {e.SystemEconomy_Localised} and {e.SystemSecondEconomy_Localised}" + Environment.NewLine
                //$"Faction: {Program.EliteAPI.lastSystem.SystemFaction}" + Environment.NewLine, true);
                , true);

            embed.AddField("Jump information",
                $"Distance: {Math.Round(e.JumpDist, 1)} ly" + Environment.NewLine +
                $"Fuel used: {Math.Round(e.FuelUsed, 1)} tonnes" + Environment.NewLine +
                $"Fuel left: {Math.Round(e.FuelLevel, 1)} tonnes" + Environment.NewLine 
                //Scoopable(Program.EliteAPI.lastSystem.Class) + Environment.NewLine, true);
                , true);

            Program.Send(embed);
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
