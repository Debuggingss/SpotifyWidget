using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.SharpDeskBand;

namespace SpotifyWidget
{
    [ComVisible(true)]
    [DisplayName("Spotify Widget")]
    public class SpotifyWidget : SharpDeskBand
    {
        protected override System.Windows.Forms.UserControl CreateDeskBand()
        {
            return new DeskbandControl();
        }

        protected override BandOptions GetBandOptions() => new BandOptions
        {
            HasVariableHeight = false,
            IsSunken = false,
            ShowTitle = true,
            Title = "Spotify Widget",
            UseBackgroundColour = false,
            AlwaysShowGripper = true
        };
    }
}
