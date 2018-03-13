using System;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Exception
{
    public class InvalidOperationServiceException : InvalidOperationException
    {
        public InvalidOperationServiceException()
            : base ("You don't request data or service doesn't work.")
        {
        }
    }
}
