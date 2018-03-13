using NET.W._2018.Zenovich._01.API;
using NET.W._2018.Zenovich._01.Model;
using NET.W._2018.Zenovich._01.ServiceClassification.API;
using NET.W._2018.Zenovich._01.ServiceClassification.Model;
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
            int[] array = { 3, 8, 2, 1, 3335, 4, -6, 7, 22, 24, 123, 12, 11, 440, 0, -1, -3232 };

            IArrayUtils arrayUtils = new ArrayUtils();
            arrayUtils.MergeSort(array);

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new String('-', 30));
            IService service = new NewsService("NewService", "http://localhost"); 
           
            Console.ReadKey();
        }
    }
}
