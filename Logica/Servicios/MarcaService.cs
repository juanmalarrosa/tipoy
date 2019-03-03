using System;
using Entidades;
using System.Collections.Generic;
using Excepciones;

namespace Logica
{
    public class MarcaService : BaseService<Marca>, IMarcaService
    {

        private readonly IMarcaDataAccess _marcaDataAccess;

        public MarcaService(IMarcaDataAccess marcaDataAccess)
        {
            _marcaDataAccess = marcaDataAccess;
            
        }


        public void Agregar(Marca marca)
        {

            if (EsValidoParaAgregar(marca))
            {
                _marcaDataAccess.Agregar(marca);
            }

        }

        public Marca Obtener(Marca marca)
        {

            Marca returnMarca = null;

            returnMarca = _marcaDataAccess.Encontrar(marca.Id);

            if (returnMarca == null)
            {
                throw new ExceptionNotExistingObject("Marca no existe");
            }

            return returnMarca;

        }

        public Marca ObtenerPorId(int id)
        {

            Marca returnMarca = null;

            returnMarca = _marcaDataAccess.Encontrar(id);

            if (returnMarca == null)
            {
                throw new ExceptionNotExistingObject("User does not exist");
            }

            return returnMarca;

        }

        public bool EsValido(Marca marca)
        {
            if (IsNull(marca))
            {
                throw new ExceptionNULLObject("User can not be null");
            }
            else if (!ValidarData(marca))
            {
                throw new ExceptionInvalidString("There are invalid fields");
            }


            return true;
        }


        public bool Existe(Marca marca)
        {

            Marca returnMarca;

            returnMarca = _marcaDataAccess.Encontrar(marca.id);

            if (returnMarca != null)
            {
                return true;
            }

            return false;


        }

        public List<Marca> ObtenerLista()
        {

            List<Marca> ret = new List<Marca>();


            if (Cantidad() != 0)
            {
                ret = _marcaDataAccess.Lista();

            }
            else
            {
                throw new ExceptionEmptyList("Userlist is empty");
            }


            return ret;

        }

        public int Cantidad()
        {
            return _marcaDataAccess.CantidadLista();
        }

        public void Borrar(Marca marca)
        {
            if (Existe(marca))
            {
                _marcaDataAccess.Borrar(marca);
            }
            else
            {
                throw new ExceptionNotExistingObject("User to delete does not exist");

            }

        }


        //Marca methods


        public bool ValidarData(Marca marca)
        {
            bool ret = false;
            if (ValidString(marca.Nombre))
            {
                ret = true;
            }

            return ret;
        }





        public bool EsValidoParaAgregar(Marca marca)
        {
            EsValido(marca);

            if (Existe(marca) || ExistePorNombre(marca.Nombre))
            {
                throw new ExceptionExistingObject("User username already exists");
            }

            return true;
        }


        public bool ExistePorNombre(String nombre)
        {

            Marca returnMarca = _marcaDataAccess.EncontrarPorNombre(nombre);

            if (returnMarca != null)
            {
                return true;
            }

            return false;

        }


        public void Modificar(Marca marca, Marca nuevaMarca)
        {

            if (!ExistePorNombre(nuevaMarca.Nombre) || marca.Nombre == nuevaMarca.Nombre)
            {
                if (Existe(marca) && ValidString(nuevaMarca.Nombre))
                {
                    _marcaDataAccess.Modificar(marca, nuevaMarca);
                }
            }
            else
            {
                throw new ExceptionExistingObject("User already exists");
            }

        }



    }
}
