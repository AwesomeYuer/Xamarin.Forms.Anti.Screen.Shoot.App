namespace XF.AntiScreenShoot.App.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Microshaoft;
    using System.Net;
    using Xamarin.Essentials;

    [Activity(Label = "XF.AntiScreenShoot.App", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            SystemHelper.OnGetSystemProxyInfoProcessFunc = () =>
            {
                string host = Java.Lang.JavaSystem.GetProperty("http.proxyHost");
                ushort? port = null;
                string p = Java.Lang.JavaSystem.GetProperty("http.proxyPort");

                if
                    (
                        ushort
                            .TryParse
                                (
                                       p
                                       , out var @value
                                )
                    )
                {
                    port = @value;
                }

                if (!string.IsNullOrEmpty(host))
                {
                    host = host.TrimEnd('/');
                    if
                        (
                            IPAddress.TryParse
                                        (
                                            host
                                            , out _
                                        )
                        )
                    { 
                    
                    }
                    ;
                }
                return 
                    (
                        host
                        , port
                    );
            };
            ScreenShooterHelper.OnProcessAction = (disable) =>
            {
                if (disable)
                {
                    Window.SetFlags(WindowManagerFlags.Secure, WindowManagerFlags.Secure);
                }
                else
                {
                    Window.ClearFlags(WindowManagerFlags.Secure);
                }
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}