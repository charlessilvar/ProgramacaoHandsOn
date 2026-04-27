using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing() 
        {
            //SearchDNS();
            //BuildPPacket();
            return "Success: Ping Sent";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }
        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingsOptions = new List<PingOptions>{
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1
                }
            };
            return pingsOptions;
        }
    }
}
