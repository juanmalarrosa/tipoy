using System;


namespace Excepciones
{
    public class ExceptionEmptyList : Exception
    {
        public ExceptionEmptyList() : base()
        {
        }

        public ExceptionEmptyList(string message)
        : base(message)
        {
        }

        public ExceptionEmptyList(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
