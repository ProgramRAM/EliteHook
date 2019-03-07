using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Discord;
using Discord.Webhook;

using EliteAPI;

using EliteHook.Events;

namespace EliteHook
{
    public partial class Main : Form
    {
        public static EliteDangerousAPI EliteAPI;
        private static DiscordWebhookClient webhook;

        private static bool isOn;
        private string Url { get { return txtUrl.Text; } set { txtUrl.Invoke(new Action(() => txtUrl.Text = value)); } }
        private static bool isRichPresenceOn;

        public Main(EliteDangerousAPI elite)
        {
            InitializeComponent();
            EliteAPI = elite;
            this.Shown += (sender, e) => Task.Run(() => Ready());

            EliteAPI.Logger.Log += (sender, e) =>
            {
                txtLog.Invoke(new Action(() => txtLog.AppendText(e.Message + Environment.NewLine)));
                txtLog.Invoke(new Action(() => txtLog.ScrollToCaret()));
            };
        }

        public void Ready()
        {
            try { Url = File.ReadAllText(Directory.GetCurrentDirectory() + "\\webhook.txt"); } catch { }
        }

        private void Shake(TextBox t)
        {
            bool even = false;
            Point orgPos = t.Location;

            for (int i = 0; i < 4; i++)
            {
                even = !even;
                if (even)
                {
                    t.Invoke(new Action(() => t.Location = new Point(t.Location.X + 2, t.Location.Y)));
                }
                else { t.Invoke(new Action(() => t.Location = new Point(t.Location.X - 2, t.Location.Y))); }
                Thread.Sleep(100);
            }

            t.Invoke(new Action(() => t.Location = orgPos));
        }

        private void btnTest_Click(object sender, System.EventArgs e)
        {
            try
            {
                webhook = new DiscordWebhookClient(ulong.Parse(Url.Split('/')[5]), Url.Split('/')[6]);
                webhook.SendMessageAsync("```Beep boop, testing!```");
                btnTest.ForeColor = System.Drawing.Color.FromArgb(128, 255, 128);
                Task.Run(() => { Thread.Sleep(1000); btnTest.Invoke(new Action(() => btnTest.ForeColor = System.Drawing.Color.FromName("Gray"))); });
            }
            catch { Shake(txtUrl); }
        }

        private void btnToggle_Click(object sender, System.EventArgs e)
        {
            txtCommander.Text = "Commander " + EliteAPI.Commander.Commander;

            isOn = !isOn;

            try
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\webhook.txt", Url);
            }
            catch { }

            if (!isOn)
            {
                //Turn API off.
                btnToggle.ForeColor = System.Drawing.Color.FromArgb(128, 255, 128);
                btnToggle.Text = "turn on";

                EliteAPI.Events.DockingGrantedEvent -= DockingGranted.EliteAPI_DockingGrantedEvent;
                EliteAPI.Events.DockingDeniedEvent -= DockingDenied.EliteAPI_DockingDeniedEvent;
                EliteAPI.Events.FSDJumpEvent -= FSDJump.EliteAPI_FSDJumpEvent;
                EliteAPI.Events.SupercruiseEntryEvent -= SupercruiseEntry.EliteAPI_SupercruiseEntryEvent;
                EliteAPI.Events.SupercruiseExitEvent -= SupercruiseExit.EliteAPI_SupercruiseExitEvent;
                EliteAPI.Events.StatusLowFuelEvent -= Lowfuel.EliteAPI_LowFuelEvent;
                EliteAPI.Events.HullDamageEvent -= HullDamage.EliteAPI_HullDamageEvent;
                EliteAPI.Events.UnderAttackEvent -= UnderAttack.EliteAPI_UnderAttackEvent;
                EliteAPI.Events.BountyEvent -= Bounty.EliteAPI_BountyEvent;
                EliteAPI.Events.CommitCrimeEvent -= CommitCrime.EliteAPI_CommitCrimeEvent;
                EliteAPI.Events.InterdictionEvent -= Interdiction.EliteAPI_InterdictionEvent;
                EliteAPI.Events.CollectCargoEvent -= CollectCargo.EliteAPI_CollectCargoEvent;
                EliteAPI.Events.MaterialCollectedEvent -= MaterialCollected.EliteAPI_MaterialCollectedEvent;
                EliteAPI.Events.SelfDestructEvent -= SelfDestruct.EliteAPI_SelfDestructEvent;
                EliteAPI.Events.DiedEvent -= Died.EliteAPI_DiedEvent;
                EliteAPI.Events.DockedEvent -= Docked.EliteAPI_DockedEvent;
                EliteAPI.Events.UndockedEvent -= Undocked.EliteAPI_UndockedEvent;
                EliteAPI.Events.USSDropEvent -= USSDrop.USSDropEvent;
                EliteAPI.Events.MusicEvent -= Music.EliteAPI_MusicEvent;
                EliteAPI.Events.LoadGameEvent -= LoadGame.EliteAPI_LoadGameEvent;
                EliteAPI.Events.RedeemVoucherEvent -= RedeemVoucher.EliteAPI_RedeemVoucherEvent;
                EliteAPI.Events.ProgressEvent -= Progress.EliteAPI_ProgressEvent;
                EliteAPI.Events.SendTextEvent -= SendText.EliteAPI_SendTextEvent;
                EliteAPI.Events.MarketBuyEvent -= MarketBuy.EliteAPI_MarketBuyEvent;
                EliteAPI.Events.MarketSellEvent -= MarketSell.EliteAPI_MarketSellEvent;
            }
            else
            {
                //Turn API on.
                btnToggle.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
                btnToggle.Text = "turn off";
                try
                {
                    webhook = new DiscordWebhookClient(ulong.Parse(Url.Split('/')[5]), Url.Split('/')[6]);
                }
                catch { Shake(txtUrl); btnToggle.PerformClick(); return; }

                EliteAPI.Events.DockingGrantedEvent += DockingGranted.EliteAPI_DockingGrantedEvent;
                EliteAPI.Events.DockingDeniedEvent += DockingDenied.EliteAPI_DockingDeniedEvent;
                EliteAPI.Events.FSDJumpEvent += FSDJump.EliteAPI_FSDJumpEvent;
                EliteAPI.Events.SupercruiseEntryEvent += SupercruiseEntry.EliteAPI_SupercruiseEntryEvent;
                EliteAPI.Events.SupercruiseExitEvent += SupercruiseExit.EliteAPI_SupercruiseExitEvent;
                EliteAPI.Events.StatusLowFuelEvent += Lowfuel.EliteAPI_LowFuelEvent;
                EliteAPI.Events.HullDamageEvent += HullDamage.EliteAPI_HullDamageEvent;
                EliteAPI.Events.UnderAttackEvent += UnderAttack.EliteAPI_UnderAttackEvent;
                EliteAPI.Events.BountyEvent += Bounty.EliteAPI_BountyEvent;
                EliteAPI.Events.CommitCrimeEvent += CommitCrime.EliteAPI_CommitCrimeEvent;
                EliteAPI.Events.InterdictionEvent += Interdiction.EliteAPI_InterdictionEvent;
                EliteAPI.Events.CollectCargoEvent += CollectCargo.EliteAPI_CollectCargoEvent;
                EliteAPI.Events.MaterialCollectedEvent += MaterialCollected.EliteAPI_MaterialCollectedEvent;
                EliteAPI.Events.SelfDestructEvent += SelfDestruct.EliteAPI_SelfDestructEvent;
                EliteAPI.Events.DiedEvent += Died.EliteAPI_DiedEvent;
                EliteAPI.Events.DockedEvent += Docked.EliteAPI_DockedEvent;
                EliteAPI.Events.UndockedEvent += Undocked.EliteAPI_UndockedEvent;
                EliteAPI.Events.USSDropEvent += USSDrop.USSDropEvent;
                EliteAPI.Events.MusicEvent += Music.EliteAPI_MusicEvent;
                EliteAPI.Events.LoadGameEvent += LoadGame.EliteAPI_LoadGameEvent;
                EliteAPI.Events.RedeemVoucherEvent += RedeemVoucher.EliteAPI_RedeemVoucherEvent;
                EliteAPI.Events.ProgressEvent += Progress.EliteAPI_ProgressEvent;
                EliteAPI.Events.SendTextEvent += SendText.EliteAPI_SendTextEvent;
                EliteAPI.Events.MarketBuyEvent += MarketBuy.EliteAPI_MarketBuyEvent;
                EliteAPI.Events.MarketSellEvent += MarketSell.EliteAPI_MarketSellEvent;

            }
        }

        public static void Send(EmbedBuilder embed)
        {
            EliteAPI.Logger.LogDebug($"Sending webhook: '{Newtonsoft.Json.JsonConvert.SerializeObject(embed)}'.");

            embed.WithCurrentTimestamp();
            try
            {
                webhook.ModifyWebhookAsync(x => x.Name = "CMDR " + EliteAPI.Commander.Commander);
            }
            catch {}

            IEnumerable<Embed> embeds = new List<Embed>() { embed.Build() };
            webhook.SendMessageAsync("", false, embeds);
        }

        private void btnRichPresence_Click(object sender, EventArgs e)
        {
            isRichPresenceOn = !isRichPresenceOn;

            if(isRichPresenceOn)
            {
                //Turn rich presence off.
                btnRichPresence.ForeColor = System.Drawing.Color.FromArgb(128, 255, 128);
                EliteAPI.DiscordRichPresence.TurnOn();
            } else
            {
                //Turn rich presence on.
                btnRichPresence.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
                EliteAPI.DiscordRichPresence.TurnOff();
            }
        }
    }
}
