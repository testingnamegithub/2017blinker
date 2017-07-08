using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BlinkBlink_EyeJoah
{
    class CheckInternetConnection
    {
        private static CheckInternetConnection exception;

        public static CheckInternetConnection GetInstance()
        {
            if (exception == null)
            {
                exception = new CheckInternetConnection();
            } // if
            return exception;

        } // Method - Getinstance


        public bool CheckForConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
