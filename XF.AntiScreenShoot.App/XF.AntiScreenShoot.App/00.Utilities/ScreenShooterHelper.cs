namespace Microshaoft
{
    using System;

    public static class ScreenShooterHelper
    {
        public static Action<bool> OnProcessAction;
        public static void OnDisableProcess(object sender, EventArgs e)
        {
            Disable();
        }
        public static void OnEnableProcess(object sender, EventArgs e)
        {
            Enable();
        }
        public static bool Disable()
        {
            var r = false;
            OnProcessAction?.Invoke(true);
            r = true;
            return
                r;
        }
        public static bool Enable()
        {
            var r = false;
            OnProcessAction?.Invoke(false);
            r = true;
            return
                r;
        }
    }
}
