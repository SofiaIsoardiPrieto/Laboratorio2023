using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosTipoRangos
    {
        void Borrar(int tipoRangoId);
        bool EstaRelacionado(int tipoRangoId);
        bool Existe(TipoRango tipoRango);
        int GetCantidad(string textoFiltro=null);
        List<TipoRango> GetTipoRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
        void Guardar(TipoRango tipoRango);
    }
}
