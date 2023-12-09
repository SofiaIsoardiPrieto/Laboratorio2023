using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosPruebas:IServiciosPruebas
    {
        private readonly IRepositorioPruebas _repositorio;
        public ServiciosPruebas()
        {
            _repositorio = new RepositorioPruebas();
        }

        public void Borrar(int pruebaId)
        {
            try
            {
                _repositorio.Borrar(pruebaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int pruebaId)
        {
            try
            {
                return _repositorio.EstaRelacionado(pruebaId);
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

        public List<PruebaCombo> GetPruebaCombo(int? examenId)
        {
            try
            {
                return _repositorio.GetPruebaCombo(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PruebaDto> GetPruebaDtosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetPruebaDtosPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
