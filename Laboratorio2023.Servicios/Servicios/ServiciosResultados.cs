using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosResultados: IServiciosResultados
    {

        private readonly IRepositorioResultados _repositorio;
        public ServiciosResultados()
        {
            _repositorio = new RepositorioResultados();
        }

        public void Borrar(int resultadoId)
        {
            try
            {
                _repositorio.Borrar(resultadoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CrearAnalisis(int protocoloId, List<ExamenPrueba> examenPruebas)
        {
            try
            {
                _repositorio.CrearAnalisis(protocoloId, examenPruebas);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Resultado resultado)
        {
            try
            {
                return _repositorio.Existe(resultado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                return _repositorio.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public List<ResultadoDto> GetResultadosDtoPorPagina(int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetResultadosDtoPorPagina(registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //revisar si necesita algun filtro


        //public List<ResultadoDto> GetResultadosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null, DateTime? fechaFiltro = null)
        //{
        //    try
        //    {
        //        return _repositorio.GetResultadosPorPagina( registrosPorPagina,  paginaActual,  textoFiltro = null, DateTime ? fechaFiltro = null)
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public void Guardar(Resultado resultado)
        {
            if (resultado.ResultadoId == 0)
            {
                _repositorio.Agregar(resultado);
            }
            else
            {
                _repositorio.Editar(resultado);
            }
        }
    }
}
