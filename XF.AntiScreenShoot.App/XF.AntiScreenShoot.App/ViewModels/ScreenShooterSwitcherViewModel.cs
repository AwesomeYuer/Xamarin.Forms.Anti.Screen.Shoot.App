namespace XF.AntiScreenShoot.App.ViewModels
{
    //using PropertyChanged;
    using System;
    using System.ComponentModel;
    //[AddINotifyPropertyChangedInterface]
    public class ScreenShooterSwitcherViewModel : INotifyPropertyChanged
    {
        private readonly Action<bool> _action;
        public ScreenShooterSwitcherViewModel(Action<bool> onScreenShootToggledProcessAction)
        {
            _action = onScreenShootToggledProcessAction;
        }
        //[AlsoNotifyFor("ScreenShootState")]
        public bool IsScreenShootToggled
        {
            get;
            set;
        }
        public string ScreenShootState
        {
            get
            {
                return 
                    (
                        IsScreenShootToggled
                        ?
                        "Disable"
                        :
                        "Enable"
                    )
                    +
                    " Screen Shoot"
                    ;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?
                        .Invoke
                            (
                                this
                                , new PropertyChangedEventArgs(propertyName)
                            );
            if (propertyName == "IsScreenShootToggled")
            {
                _action(IsScreenShootToggled);
            }
        }
    }
}
