using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace wcf.service
{
    class HomeService : IHomeService
    {
        public string DoWork(string msg)
        {
            var ip = Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(i => i.AddressFamily == AddressFamily.InterNetwork).ToString();
            return string.Format("{0}", ip);
        }
    }
}
