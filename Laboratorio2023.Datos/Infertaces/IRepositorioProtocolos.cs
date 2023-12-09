using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioProtocolos
    {
        void Agregar(Protocolo protocolo);
        void Borrar(int protocoloId);
        void Editar(Protocolo protocolo);
        bool EstaRelacionado(int protocoloId);
        bool Existe(Protocolo protocolo);
        int GetCantidad(string textoFiltro, DateTime? fechaFiltro);
        List<Protocolo> GetProtocolosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro, DateTime? fechaFiltro);
    }
}
