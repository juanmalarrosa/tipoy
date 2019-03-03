using System;


namespace Excepciones
{
    public class ExceptionExistingObject : Exception
    {
        public ExceptionExistingObject() : base()
        {
        }

        public ExceptionExistingObject(string message)
        : base(message)
        {
        }

        public ExceptionExistingObject(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
