using NET.W._2018.Zenovich._01.ServiceClassification.API;
using NET.W._2018.Zenovich._01.ServiceClassification.Exception;
using System;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Model
{
    public class NewsService : Service
    {
        private string _title;
        private string _body;

        public NewsService(string name, string urlAddress)
            : base(name, urlAddress)
        {
        }

        public string Title
        {
            get
            {
                return _title ?? throw new InvalidOperationServiceException();
            }
            set
            {
                _title = value ?? throw new ArgumentNullException(nameof(Title));
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
            if (_title == null)
            {
                throw new InvalidOperationException($"{nameof(Title)} is undefined");
            }

            Console.WriteLine($"{nameof(NewsService)}...");

            _body = "All is okey. People are fine!";

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nTtile: {_title}\nBody: {_body}\n";
        }
    }
}
