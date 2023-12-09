using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosResultados
    {
        void Borrar(int resultadoId);
        void CrearAnalisis(int protocoloId, List<ExamenPrueba> examenPruebas);
        bool Existe(Resultado resultado);
        int GetCantidad();
        List<ResultadoDto> GetResultadosDtoPorPagina(int registrosPorPagina, int paginaActual);
        void Guardar(Resultado resultado);
    }
}
