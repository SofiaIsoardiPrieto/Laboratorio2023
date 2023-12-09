using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioPruebas
    {
        void Borrar(int pruebaId);
       
        bool EstaRelacionado(int pruebaId);
        int GetCantidad(string textoFiltro);
        List<PruebaCombo> GetPruebaCombo(int? examenId);
        List<PruebaDto> GetPruebaDtosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
    }
}
