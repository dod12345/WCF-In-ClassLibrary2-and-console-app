using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(ClassLibrary2.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}