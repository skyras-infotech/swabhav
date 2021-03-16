using System;

namespace CustomExceptionApp.Model
{
    class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message) : base(message) { }
    }
}
