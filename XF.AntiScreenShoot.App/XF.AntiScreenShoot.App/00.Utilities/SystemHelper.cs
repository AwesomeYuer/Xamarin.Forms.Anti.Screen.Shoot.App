namespace Microshaoft
{
    using System;
    using System.Net;
    public class SystemHelper
    {
        public static Func<(string, ushort?)> OnGetSystemProxyInfoProcessFunc;
        
        public static WebProxy GetSystemWebProxy()
        {
            WebProxy webProxy = null;
            string host = string.Empty;
            ushort? port = null;
            if (OnGetSystemProxyInfoProcessFunc != null)
            {
                (host, port) = OnGetSystemProxyInfoProcessFunc();
            }
            if (!string.IsNullOrEmpty(host) && port != null)
            {
                webProxy = new WebProxy($"{host}:{port}", true);
            }
            return webProxy;
        }
    }
}
