using EliteAPI;
using Somfic.Logging;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Threading;

namespace EliteHook
{


    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Splash : Window
    {
        public Splash()
        {
            InitializeComponent();

            EliteDangerousAPI api = new EliteDangerousAPI();
            api.Logger.LogEvent += (sender, e) =>
            {
                BackgroundLogging.Dispatcher.Invoke(new Action(() => BackgroundLogging.AppendText(e.Content + Environment.NewLine)));
                BackgroundLogging.Dispatcher.Invoke(new Action(() => BackgroundLogging.ScrollToEnd()));
            };

            MainWindow main = new MainWindow(api);

            api.OnLoad += (sender, e) => UpdateProgress(e.Item1, e.Item2);
            api.OnError += (sender, e) => UpdateError(e.Item1);
            api.OnReady += (sender, e) =>
            {
                UpdateDone();
                Task.Run(() =>
                {
                    Thread.Sleep(1500);
                    main.Dispatcher.Invoke(new Action(() => main.Show()));
                    Dispatcher.Invoke(new Action(() => Hide()));
                });
                
            };

            Task.Run(() => { api.Start(); });
        }

        private void UpdateDone()
        {
            UpdateProgress(Color.FromRgb(133, 255, 92), 1, "EliteAPI is ready");
        }

        private void UpdateError(string text)
        {
            UpdateProgress(Color.FromRgb(255, 92, 111), 1, text);
        }

        private void UpdateProgress(string text, float progress)
        {
            UpdateProgress(Color.FromRgb(255, 255, 255), progress, text);
        }

        private void UpdateProgress(Color color, float progress, string text)
        {
            Progress.Dispatcher.Invoke(new Action(() => Progress.Fill = new SolidColorBrush(color)));
            ProgressDone.Dispatcher.Invoke(new Action(() => ProgressDone.Width = new GridLength(Math.Min(progress * 100, 100), GridUnitType.Star)));
            ProgressLeft.Dispatcher.Invoke(new Action(() => ProgressLeft.Width = new GridLength(Math.Max(progress * 100 - 100, 0), GridUnitType.Star)));
            ProgessContent.Dispatcher.Invoke(new Action(() => ProgessContent.Text = text));
        }
    }
}
