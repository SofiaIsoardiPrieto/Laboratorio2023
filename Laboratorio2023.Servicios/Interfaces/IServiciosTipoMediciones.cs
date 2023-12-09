using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosTipoMediciones
    {
        void Borrar(int tipoMedicionId);
        bool EstaRelacionado(int tipoMedicionId);
        bool Existe(TipoMedicion tipoMedicion);
        int GetCantidad(string textoFiltro=null);
        List<TipoMedicion> GetTipoMedicionesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
        void Guardar(TipoMedicion tipoMedicion);
    }
}
