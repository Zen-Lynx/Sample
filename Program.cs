using System;

using InterstellarLynx.Samples.Day1;
using InterstellarLynx.Experimental;

namespace InterstellarLynx.Main
{
    class Lynx
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Longhorn Manager Shell v0.1");
            Console.ResetColor();
            //Sd01.sdx01();
            Nethorn.PinghornAsync("longhorn.ga");
            Nethorn.PinghornAsync("api.longhorn.ga");
            Nethorn.PinghornAsync("dyn.longhorn.ga");
            Nethorn.PinghornAsync("fs.longhorn.ga");
            Nethorn.PinghornAsync("gcloud.longhorn.ga");
            Nethorn.PinghornAsync("gcloud-us1.longhorn.ga");
            Nethorn.PinghornAsync("shell.longhorn.ga");
            Nethorn.PinghornAsync("wcksoft.com");
            Nethorn.PinghornAsync("automatedtek.com");
            Nethorn.PinghornAsync("impactatv.com");
            Nethorn.PinghornAsync("skyhorn.com");
            Nethorn.PinghornAsync("loblaws.ca");
            Nethorn.PinghornAsync("loblaws.com");
            Nethorn.PinghornAsync("loblaws.longhorn.ga");
        }
    }
}
