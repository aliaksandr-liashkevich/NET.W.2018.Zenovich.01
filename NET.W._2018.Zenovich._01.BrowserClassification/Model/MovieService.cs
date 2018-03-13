using NET.W._2018.Zenovich._01.ServiceClassification.API;
using System;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Model
{
    public class MovieService : Service
    {
        private string _movie;
        private string _description;

        public MovieService(string name, string urlAdress) 
            : base(name, urlAdress)
        {
        }

        public string Movie
        {
            get
            {
                return _movie ?? throw new InvalidOperationException();
            }
            set
            {
                _movie = value ?? throw new ArgumentNullException(nameof(Movie));
            }
        }

        public string Description
        {
            get
            {
                return _description ?? throw new InvalidOperationException();
            }
        }

        public override string Request()
        {
            if (_movie == null)
            {
                throw new InvalidOperationException($"{nameof(Movie)} is undefined");
            }

            Console.WriteLine($"{nameof(NewsService)}...");

            _description = "This movie is about dream!";

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nMovie: {_movie}\nDescription: {_description}\n";
        }
    }
}
