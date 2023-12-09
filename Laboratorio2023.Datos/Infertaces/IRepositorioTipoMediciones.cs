using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioTipoMediciones
    {
        void Agregar(TipoMedicion tipoMedicion);
        void Borrar(int tipoMedicionId);
        void Editar(TipoMedicion tipoMedicion);
        bool EstaRelacionado(int tipoMedicionId);
        bool Existe(TipoMedicion tipoMedicion);
        int GetCantidad(string textoFiltro);
        List<TipoMedicion> GetTipoMedicionesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro);
    }
}
