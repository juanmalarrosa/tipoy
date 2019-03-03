using System;


namespace Excepciones
{
    public class ExceptionNotExistingObject : Exception
    {
        public ExceptionNotExistingObject() : base()
        {
        }

        public ExceptionNotExistingObject(string message)
        : base(message)
        {
        }

        public ExceptionNotExistingObject(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
