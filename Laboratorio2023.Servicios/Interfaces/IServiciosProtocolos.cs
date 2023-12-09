using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosProtocolos
    {
        void Borrar(int protocoloId);
        bool EstaRelacionado(int protocoloId);
        bool Existe(Protocolo protocolo);
        int GetCantidad(string textoFiltro = null, DateTime? fechaFiltro = null);
        List<Protocolo> GetProtocolosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null, DateTime? fechaFiltro = null);
        void Guardar(Protocolo protocolo);
    }
}
