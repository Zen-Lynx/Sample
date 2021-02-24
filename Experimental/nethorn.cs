using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace InterstellarLynx.Experimental
{
    class Nethorn
    {
        public static void PinghornAsync(string hostname) {
                Ping pingSender = new Ping();
                string host = hostname;
                var dateutc = DateTime.UtcNow;
                Console.WriteLine($"[{dateutc}] {host} : Syncing...");
                try {
                PingReply reply = pingSender.Send(host);
                
                        if (reply.Status == IPStatus.Success)
                        {
                            var date = DateTime.UtcNow;
                            Console.SetCursorPosition(0, Console.CursorTop -1);
                            Console.Write($"[{date}] {host} : ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Operational            ");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            var date = DateTime.UtcNow;
                            Console.SetCursorPosition(0, Console.CursorTop -1);
                            Console.Write($"[{date}] {host} : ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Outage           ");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }    
                } catch {
                            var date = DateTime.UtcNow;
                            Console.SetCursorPosition(0, Console.CursorTop -1);
                            Console.Write($"[{date}] {host} : ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Failed Resolve DNS           ");
                            Console.ResetColor();
                            Console.WriteLine("");
                }
        }
    }
}
