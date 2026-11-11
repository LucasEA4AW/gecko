using Android.App;
using Android.Runtime;

namespace Gecko
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => Gecko.CreateMauiApp();
    }
}
