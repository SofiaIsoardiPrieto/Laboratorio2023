using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioResultados
    {
        void Agregar(Resultado resultado);
        void Borrar(int resultadoId);
        void CrearAnalisis(int protocoloId, List<ExamenPrueba> examenPruebas);
        void Editar(Resultado resultado);
        bool Existe(Resultado resultado);

        int GetCantidad();
        List<ResultadoDto> GetResultadosDtoPorPagina(int registrosPorPagina, int paginaActual);
    }
}
