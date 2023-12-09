using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosTipoRangos : IServiciosTipoRangos
    {
        private readonly IRepositorioTipoRangos _repositorio;
        public ServiciosTipoRangos()
        {
            _repositorio = new RepositorioTipoRangos();
        }

        public void Borrar(int tipoRangoId)
        {
            try
            {
                _repositorio.Borrar(tipoRangoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int tipoRangoId)
        {
            try
            {
                return _repositorio.EstaRelacionado(tipoRangoId);
            }
            catch (Exception)
            {

                throw;
            }
        }
            public bool Existe(TipoRango tipoRango)
            {
                try
                {
                    return _repositorio.Existe(tipoRango);
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

            public List<TipoRango> GetTipoRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
            {
                try
                {
                    return _repositorio.GetTipoRangosPorPagina(registrosPorPagina, paginaActual, textoFiltro);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void Guardar(TipoRango tipoRango)
            {
                if (tipoRango.TipoRangoId == 0)
                {
                    _repositorio.Agregar(tipoRango);
                }
                else
                {
                    _repositorio.Editar(tipoRango);
                }
            }
        }
    }
