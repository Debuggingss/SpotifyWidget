using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyWidget
{
    public partial class DeskbandControl : UserControl
    {
        private static ToolTip toolTip;

        protected override void OnLoad(EventArgs e)
        {
            toolTip = new ToolTip();
        }

        public DeskbandControl()
        {
            InitializeComponent();
        }

        internal void Close()
        {
            timer.Enabled = false;
            timer.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string currentTrack = GetSpotifyTrackInfo();

            if (currentTrack == null && Visible)
            {
                Hide();
                return;
            }
            else if (currentTrack != null && !Visible)
            {
                Show();
            }

            trackTitleLabel.Text = currentTrack;
            toolTip.SetToolTip(trackTitleLabel, currentTrack);
        }

        public string GetSpotifyTrackInfo()
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
            {
                return null;
            }

            if (proc.MainWindowTitle.StartsWith("Spotify"))
            {
                return "Paused";
            }

            return proc.MainWindowTitle;
        }
    }
}
