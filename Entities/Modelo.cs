using System;

namespace Entidades
{
    public class Modelo
    {

        public int Id { get; set; }
        public Marca Marca { get; set; }
        public string Nombre { get; set; }


        public override int GetHashCode()

        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Modelo)
            {
                var that = obj as Modelo;
                return this.Id == that.Id;
            }

            return false;
        }
    }
}
