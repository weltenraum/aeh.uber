using System;

namespace aeh.uber.Interfaces.Exceptions
{
    public class GeneralUberException : Exception
    {
        public GeneralUberException() : base()
        {
            
        }

        public GeneralUberException(string message) : base(message)
        {
            
        }

        public GeneralUberException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}