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

            int[] arrayQ = { 3, 8, 2, 1, 3335, 4, -6, 7, 2, -3232, 123, 33, 2, -1, 0, 0, 0 };

            arrayUtils.MergeSort(arrayQ);

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new String('-', 30));

            NewsService newsService = new NewsService("NewService", "http://localhost")
            {
                Title = "News about Minsk"
            };
            DateTimeService dateTimeService = new DateTimeService("DateTimeService", "http://localhost:8080");
            MovieService movieService = new MovieService("MovieService", "http://localhost:2000")
            {
                Movie = "My life"
            };
            WeatherService weatherService = new WeatherService("WeatherService", "http://localhost:2232")
            {
                Location = "Minsk"
            };

            IEnumerable<IService> services = new List<IService>
            {
                newsService,
                dateTimeService,
                movieService,
                weatherService
            };

            foreach (var service in services)
            {
                Console.WriteLine(service.Request());
            }
            
           
            Console.ReadKey();
        }
    }
}
