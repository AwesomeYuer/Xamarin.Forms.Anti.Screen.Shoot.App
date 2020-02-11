namespace XF.AntiScreenShoot.App
{
    using System;
    using System.ComponentModel;
    using Xamarin.Forms;
    using XF.AntiScreenShoot.App.ViewModels;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(Action<bool> onScreenShootToggledProcessAction)
        {
            InitializeComponent();
            this.BindingContext = new ScreenShooterSwitcherViewModel(onScreenShootToggledProcessAction);
        }

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    _action(((Switch) sender).IsToggled);
        //}
    }
}
