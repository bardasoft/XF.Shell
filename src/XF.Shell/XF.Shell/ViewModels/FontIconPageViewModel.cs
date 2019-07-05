
using System.Linq;
using System.Reflection;
using XF.Shell.Constants;

namespace XF.Shell.ViewModels
{
    public class FontIconPageViewModel
    {
        public string AndroidIcon => IconFont.Android;
        public string AppleIcon => IconFont.Apple;
        public string TwitchIcon => IconFont.Twitch;

        public string[] Icons { get; private set; }

        public FontIconPageViewModel()
        {
            Icons = typeof( IconFont ).GetFields( BindingFlags.Static | BindingFlags.Public ).Select( x => x.GetValue( null ) as string ).ToArray();
        }
    }
}
