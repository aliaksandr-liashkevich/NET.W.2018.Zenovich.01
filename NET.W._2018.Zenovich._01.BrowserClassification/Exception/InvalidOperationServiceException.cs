using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Exception
{
    class InvalidOperationServiceException : InvalidOperationException
    {
        public InvalidOperationServiceException()
            : base ("You don't request data or service doesn't work.")
        {
        }
    }
}
