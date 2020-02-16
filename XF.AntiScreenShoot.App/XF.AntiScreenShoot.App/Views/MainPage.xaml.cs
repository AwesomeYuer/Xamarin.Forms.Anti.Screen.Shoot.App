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
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ScreenShooterSwitcherViewModel();
        }

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    _action(((Switch) sender).IsToggled);
        //}
    }
}
