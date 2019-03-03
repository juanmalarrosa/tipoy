using System;

namespace Entidades
{
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }


        public override int GetHashCode()

        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Producto)
            {
                var that = obj as Producto;
                return this.Id == that.Id;
            }

            return false;
        }


    }
}
