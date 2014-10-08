using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV_Server_Status
{
    class Server
    {
        public string IP = "";
        public double Latency;

        public bool PingServer(string server)
        {
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send(server);

                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
            }

            return pingable;
        }

        public double PingTimeAverage(string server, int echoNum)
        {
            long totalTime = 0;
            int timeout = 120;
            Ping pingSender = new Ping();

            for (int i = 0; i < echoNum; i++)
            {
                PingReply reply = pingSender.Send(server, timeout);
                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                }
            }

            Latency = totalTime / echoNum;
            return totalTime / echoNum; 
        }
    }
}
