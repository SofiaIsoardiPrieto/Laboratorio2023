using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosRangos:IServiciosRangos
    {

        private readonly IRepositorioRangos _repositorio;
        public ServiciosRangos()
        {
            _repositorio = new RepositorioRangos();
        }

        public void Borrar(int rangoId)
        {
            try
            {
                _repositorio.Borrar(rangoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Rango rango)
        {
            try
            {
                return _repositorio.Existe(rango);
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

        public Rango GetRangoPorId(int rangoId)
        {
            try
            {
                return _repositorio.GetRangoPorId(rangoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RangoDto> GetRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetRangosPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Rango rango)
        {
            try
            {
                if (rango.RangoId == 0)
                {
                    _repositorio.Agregar(rango);
                }
                else
                {
                    _repositorio.Editar(rango);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
