using Foundation;

namespace Gecko
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => Gecko.CreateMauiApp();
    }
}
