using System;
using Entidades;
using Excepciones;

namespace Logica
{
    public abstract class BaseService<T>
    {

        public static bool IsNull(T obj)
        {
            return ReferenceEquals(obj, null);
        }


        public static bool ValidString(String text)
        {
            bool ret = true;

            if (text.Trim() == "" || text == null)
            {
                throw new ExceptionInvalidString("There are invalid fields");
            }
            return ret;

        }
    }
}
