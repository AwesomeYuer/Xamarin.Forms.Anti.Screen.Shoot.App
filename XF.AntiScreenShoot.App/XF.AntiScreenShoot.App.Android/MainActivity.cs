namespace XF.AntiScreenShoot.App.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
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
            LoadApplication
                (
                    new App
                        (
                            (x) =>
                            {
                                if (x)
                                {
                                    Window
                                        .SetFlags
                                            (
                                                  WindowManagerFlags
                                                                .Secure
                                                , WindowManagerFlags
                                                                .Secure
                                            );
                                }
                                else
                                {
                                    Window
                                        .ClearFlags
                                            (
                                                WindowManagerFlags
                                                                .Secure
                                            );
                                }
                            }
                        )
                );
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}