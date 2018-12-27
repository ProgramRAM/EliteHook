using System;
using System.IO;
using System.Collections.Generic;

using EliteAPI;

using EliteHook.Events;

using Discord.Webhook;
using System.Threading;
using Discord;

namespace EliteHook
{
    class Program
    {
        internal static EliteDangerousAPI EliteAPI;
        internal static DiscordWebhookClient client;
        public static string webhookURL = "";

        public static int rankCombat;
        public static int rankTrade;
        public static int rankExploration;
        public static int rankEmpire;
        public static int rankFederation;
        public static int rankCQC;

        static void Main(string[] args)
        {
            Output.Start();

            if (!File.Exists("webhookurl.txt") || string.IsNullOrWhiteSpace(File.ReadAllText("webhookurl.txt")))
            {
                File.Create("webhookurl.txt");
                Console.WriteLine("Please set a webhook URL in the webhookurl.txt file and restart.");
                Thread.Sleep(-1);
            }
            else
            {
                webhookURL = File.ReadAllText("webhookurl.txt");

            }

            DirectoryInfo playerJournalFolder = new DirectoryInfo($@"C:\Users\{Environment.UserName}\Saved Games\Frontier Developments\Elite Dangerous");
            EliteAPI = new EliteDangerousAPI(playerJournalFolder, true);
            try { client = new DiscordWebhookClient(ulong.Parse(webhookURL.Split('/')[5]), webhookURL.Split('/')[6]); }
            catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Invalid URL!"); Thread.Sleep(-1); }
            client.ModifyWebhookAsync(x => x.Name = "EliteHook");
            client.ModifyWebhookAsync(x => x.Image = new Optional<Image?>(new Image("logo.png")));

            Console.WriteLine("Starting up services ... ");

            EliteAPI.DockingGrantedEvent += DockingGranted.EliteAPI_DockingGrantedEvent;
            EliteAPI.DockingDeniedEvent += DockingDenied.EliteAPI_DockingDeniedEvent;
            EliteAPI.FSDJumpEvent += FSDJump.EliteAPI_FSDJumpEvent;
            EliteAPI.SupercruiseEntryEvent += SupercruiseEntry.EliteAPI_SupercruiseEntryEvent;
            EliteAPI.SupercruiseExitEvent += SupercruiseExit.EliteAPI_SupercruiseExitEvent;
            //critical fuel
            EliteAPI.HullDamageEvent += HullDamage.EliteAPI_HullDamageEvent;
            EliteAPI.UnderAttackEvent += UnderAttack.EliteAPI_UnderAttackEvent;
            EliteAPI.BountyEvent += Bounty.EliteAPI_BountyEvent;
            EliteAPI.CommitCrimeEvent += CommitCrime.EliteAPI_CommitCrimeEvent;
            EliteAPI.InterdictionEvent += Interdiction.EliteAPI_InterdictionEvent;
            EliteAPI.CollectCargoEvent += CollectCargo.EliteAPI_CollectCargoEvent;
            EliteAPI.MaterialCollectedEvent += MaterialCollected.EliteAPI_MaterialCollectedEvent;
            EliteAPI.SelfDestructEvent += SelfDestruct.EliteAPI_SelfDestructEvent;
            EliteAPI.DiedEvent += Died.EliteAPI_DiedEvent;
            EliteAPI.DockedEvent += Docked.EliteAPI_DockedEvent;
            EliteAPI.UndockedEvent += Undocked.EliteAPI_UndockedEvent;
            EliteAPI.USSDropEvent += USSDrop.USSDropEvent;
            EliteAPI.MusicEvent += Music.EliteAPI_MusicEvent;
            EliteAPI.LoadGameEvent += LoadGame.EliteAPI_LoadGameEvent;
            EliteAPI.RedeemVoucherEvent += RedeemVoucher.EliteAPI_RedeemVoucherEvent;
            EliteAPI.RankEvent += EliteAPI_RankEvent;
            EliteAPI.ProgressEvent += Progress.EliteAPI_ProgressEvent;
            EliteAPI.SendTextEvent += SendText.EliteAPI_SendTextEvent;

            Console.WriteLine("Services loaded up, everything ready.");
            Console.WriteLine();
            Console.WriteLine("EliteHook is good to go! Start playing in game and things should update :)");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("If you close this windows EliteHook will close too");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();

            EliteAPI.Start();

            Thread.Sleep(-1);
        }

        private static void EliteAPI_RankEvent(object sender, RankInfo e)
        {
            rankCombat = e.Combat;
            rankCQC = e.CQC;
            rankEmpire = e.Empire;
            rankExploration = e.Explore;
            rankFederation = e.Federation;
            rankTrade = e.Trade;
        }

        internal static void Send(EmbedBuilder embed)
        {
            embed.WithCurrentTimestamp();

            IEnumerable<Embed> embeds = new List<Embed>() { embed.Build() };
            client.SendMessageAsync("", false, embeds);
        }
    }
}