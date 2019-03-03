using System;
using System.Collections.Generic;
using Entidades;

namespace Logica
{
    public interface IMarcaDataAccess
    {
        Marca Encontrar(int id);

        Marca EncontrarPorNombre(string nombre);

        List<Marca> Lista();

        void Agregar(Marca marca);

        void Borrar(Marca marca);

        int CantidadLista();


        //Modifiers

        void Modificar(Marca marca, Marca nuevaMarca);


    }

}