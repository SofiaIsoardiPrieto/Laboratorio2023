using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioExamenes
    {
        void Agregar(Examen examen);
        void Borrar(int examenId);
        void Editar(Examen examen);
        bool EstaRelacionado(int examenId);
        bool Existe(Examen examen);
        int GetCantidad(string textoFiltro=null);
        List<Examen> GetExamenesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
    }
}
