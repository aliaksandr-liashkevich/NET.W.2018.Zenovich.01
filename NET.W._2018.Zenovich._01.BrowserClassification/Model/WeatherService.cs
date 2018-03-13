using NET.W._2018.Zenovich._01.BrowserClassification.API;
using NET.W._2018.Zenovich._01.BrowserClassification.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01.BrowserClassification.Model
{
    public class WeatherService : Service
    {
        private double _temperature;
        private string _location;

        private WeatherService(string name, string urlAdress, string location) 
            : base(name, urlAdress)
        {
            _location = location ?? throw new ArgumentNullException(nameof(location));
            _temperature = Double.NaN;
        }

        public double Temperature
        {
            get
            {
                if (_temperature == Double.NaN)
                {
                    throw new InvalidOperationServiceException();
                }

                return _temperature;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
        }

        public override string Request()
        {
            Console.WriteLine($"{nameof(WeatherService)}...");

            _temperature = 10.5;

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nLocation: {_location}\nTemperature: {_temperature}\n";
        }
    }
}
