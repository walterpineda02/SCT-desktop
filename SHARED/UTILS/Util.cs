using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace SHARED.UTILS
{
    public static class Util
    {


        // method for get ip 
        public static string getIp() {
            Console.WriteLine("Hostname "+ Dns.GetHostName() );

            return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }
    }
}
