using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcf.client.HomeServiceReference;

namespace wcf.client
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                HomeServiceClient client = new HomeServiceClient();
                var info = client.DoWork("hw");
                Console.WriteLine(info);
                System.Threading.Thread.Sleep(1000);
            }
            Console.Read();

        }
    }
}
