using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosTipoMediciones:IServiciosTipoMediciones
    {
        private readonly IRepositorioTipoMediciones _repositorio;
        public ServiciosTipoMediciones()
        {
            _repositorio = new RepositorioTipoMediciones();
        }

        public void Borrar(int tipoMedicionId)
        {
            try
            {
                _repositorio.Borrar(tipoMedicionId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int tipoMedicionId)
        {
            try
            {
                return _repositorio.EstaRelacionado(tipoMedicionId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(TipoMedicion tipoMedicion)
        {
            try
            {
                return _repositorio.Existe(tipoMedicion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoMedicion> GetTipoMedicionesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetTipoMedicionesPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(TipoMedicion tipoMedicion)
        {
            try
            {
                if (tipoMedicion.TipoMedicionId == 0)
                {
                    _repositorio.Agregar(tipoMedicion);
                }
                else
                {
                    _repositorio.Editar(tipoMedicion);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
