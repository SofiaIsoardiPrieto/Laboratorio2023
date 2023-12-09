using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosProtocolos : IServiciosProtocolos
    {

        private readonly IRepositorioProtocolos _repositorio;
        public ServiciosProtocolos()
        {
            _repositorio = new RepositorioProtocolos();
        }

        public void Borrar(int protocoloId)
        {
            try
            {
                _repositorio.Borrar(protocoloId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int protocoloId)
        {
            try
            {
                return _repositorio.EstaRelacionado(protocoloId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Protocolo protocolo)
        {
            try
            {
                return _repositorio.Existe(protocolo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro = null, DateTime? fechaFiltro = null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro, fechaFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Protocolo> GetProtocolosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null, DateTime? fechaFiltro = null)
        {
            try
            {
                return _repositorio.GetProtocolosPorPagina(registrosPorPagina, paginaActual, textoFiltro, fechaFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Protocolo protocolo)
        {
            if (protocolo.ProtocoloId == 0)
            {
                _repositorio.Agregar(protocolo);
            }
            else
            {
                _repositorio.Editar(protocolo);
            }
        }
    }
}
