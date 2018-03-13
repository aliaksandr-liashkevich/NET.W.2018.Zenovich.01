using NET.W._2018.Zenovich._01.BrowserClassification.API;
using NET.W._2018.Zenovich._01.BrowserClassification.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01.BrowserClassification.Model
{
    class NewsService: Service
    {
        private string _title;
        private string _body;

        public NewsService(string name, string urlAddress, string title)
            : base(name, urlAddress)
        {
            _title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public string Body
        {
            get
            {
                return _body ?? throw new InvalidOperationServiceException();
            }
        }

        public override string Request()
        {
            Console.WriteLine($"{nameof(NewsService)}...");

            _body = "All is okey. People are fine!";

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nTtile: {_title}\nBody: {_body}\n";
        }
    }
}
