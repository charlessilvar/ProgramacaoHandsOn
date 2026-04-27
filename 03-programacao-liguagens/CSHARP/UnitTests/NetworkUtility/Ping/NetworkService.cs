using NetworkUtility.DNS;
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
        private readonly IDNS _dNS;
        public NetworkService(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string SendPing()
        {
            var dnsSuccess = _dNS.SendDNS();
            //BuildPPacket();
            if (dnsSuccess)
            {
                return "Success: Ping Sent";
            }
            return "Failed: Ping not sent";
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
                new() {
                    DontFragment = true,
                    Ttl = 1
                },
                new() {
                    DontFragment = true,
                    Ttl = 1
                },
                new() {
                    DontFragment = true,
                    Ttl = 1
                }
            };
            return pingsOptions;
        }
    }
}
