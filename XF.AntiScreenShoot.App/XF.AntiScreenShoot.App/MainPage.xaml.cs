using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.AntiScreenShoot.App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly Action<bool> _action;
        public MainPage(Action<bool> action)
        {
            InitializeComponent();
            _action = action;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            _action(((Switch)sender).IsToggled);
        }
    }
}
