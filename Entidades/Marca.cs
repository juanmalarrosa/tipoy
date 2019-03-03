using System;

namespace Entidades
{
    public class Marca
    {

        public int Id { get; set; }
        public string Nombre { get; set; }


        public override int GetHashCode()

        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Marca)
            {
                var that = obj as Marca;
                return this.Nombre == that.Nombre;
            }

            return false;
        }


    }
}
