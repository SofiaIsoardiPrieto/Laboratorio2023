using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioRangos
    {
        void Agregar(Rango rango);
        void Borrar(int rangoId);
        void Editar(Rango rango);
        bool Existe(Rango rango);
        int GetCantidad(string textoFiltro=null);
        Rango GetRangoPorId(int rangoId);
        List<RangoDto> GetRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
    }
}
