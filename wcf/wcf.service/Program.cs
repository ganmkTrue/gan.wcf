using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf.service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HomeService));
            host.Open();
            Console.WriteLine("启动服务");
            Console.ReadLine();
        }
    }
}
