using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioTipoRangos
    {
        void Agregar(TipoRango tipoRango);
        void Borrar(int tipoRangoId);
        void Editar(TipoRango tipoRango);
        bool EstaRelacionado(int tipoRangoId);
        bool Existe(TipoRango tipoRango);
        int GetCantidad(string textoFiltro=null);
        List<TipoRango> GetTipoRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
    }
}
