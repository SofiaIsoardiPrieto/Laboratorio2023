using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosPruebas
    {
        void Borrar(int pruebaId);
        
        bool EstaRelacionado(int pruebaId);
        int GetCantidad(string textoFiltro=null);
        List<PruebaCombo> GetPruebaCombo(int? examenId);
        List<PruebaDto> GetPruebaDtosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
    }
}
