using NET.W._2018.Zenovich._01.BrowserClassification.API;
using NET.W._2018.Zenovich._01.BrowserClassification.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new DateTimeService("TimeService", "http://localhost");
            Console.WriteLine(service.Request());
            Console.ReadKey();
        }
    }
}
