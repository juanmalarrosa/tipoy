using System;


namespace Excepciones
{
    public class ExceptionInvalidString : Exception
    {
        public ExceptionInvalidString() : base()
        {
        }

        public ExceptionInvalidString(string message)
        : base(message)
        {
        }

        public ExceptionInvalidString(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
