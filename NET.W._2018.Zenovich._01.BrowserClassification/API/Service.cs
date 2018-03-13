using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01.ServiceClassification.API
{
    public abstract class Service : IService
    {
        protected String _name;
        protected String _urlAddress;

        public Service(string name, string urlAdress)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _urlAddress = urlAdress ?? throw new ArgumentNullException(nameof(urlAdress));
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public String UrlAdress
        {
            get
            {
                return _urlAddress;
            }
        }

        public abstract string Request();
    }
}
