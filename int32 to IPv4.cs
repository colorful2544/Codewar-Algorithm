using System;
using System.Net;

namespace int32_to_IPv4
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.net.ipaddress.parse?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UInt32ToIP(2154959208));
        }
        public static string UInt32ToIP(uint ip)
        {
            IPAddress address = IPAddress.Parse(ip.ToString());
            return address.ToString();
        }
    }
}
