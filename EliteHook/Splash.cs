using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord.Webhook;
using EliteAPI;

namespace EliteHook
{
    public partial class Splash : Form
    {
        private static EliteDangerousAPI EliteAPI;

        public Splash()
        {
            InitializeComponent();
            this.Shown += (sender, e) => Task.Run(() => Ready());
        }

        public void Ready()
        {
            Thread.Sleep(1000);

            SetProgress("Starting EliteAPI ...");
            try
            {
                EliteAPI = new EliteDangerousAPI(EliteDangerousAPI.StandardDirectory, false);
                EliteAPI.Logger.UseLogFile(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)));
                EliteAPI.Start();
            }
            catch(Exception ex) { SetProgress("Error: " + ex.Message); Thread.Sleep(5000); Environment.Exit(-1); }
            if(!EliteAPI.IsRunning) { SetProgress("Could not start EliteAPI. See log files for more information");  Thread.Sleep(5000); Environment.Exit(-1); }

            SetProgress("Loading program ...");
            Main main = new Main(EliteAPI);
            main.FormClosed += Main_FormClosed;
            this.Invoke(new Action(() => this.Hide()));
            Application.Run(main);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SetProgress(string s) => txtProgress.Invoke(new Action(() => txtProgress.Text = s));
    }
}
