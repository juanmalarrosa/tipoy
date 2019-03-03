using System;


namespace Excepciones
{
    public class ExceptionNULLObject : Exception
    {
        public ExceptionNULLObject() : base()
        {
        }

        public ExceptionNULLObject(string message)
        : base(message)
        {
        }

        public ExceptionNULLObject(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
