using System;
using System.Collections.Generic;
using Entidades;

namespace Logica
{
    public interface IMarcaService
    {
        void Agregar(Marca obj);
        Marca Obtener(Marca obj);
        Marca ObtenerPorId(int id);
        bool EsValido(Marca obj);
        bool ValidarData(Marca obj);
        bool Existe(Marca obj);
        List<Marca> ObtenerLista();
        int Cantidad();
        void Borrar(Marca obj);
        void Modificar(Marca marca,Marca nuevaMarca);

    }

}