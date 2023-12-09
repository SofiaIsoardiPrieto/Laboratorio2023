using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosPacientes
    {
        void Borrar(int pacienteId);
        bool Existe(Paciente paciente);
        int GetCantidad(string textoFiltro=null);
       
        List<PacienteCombo> GetPacientesCombo();
        List<Paciente> GetPacientesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null);
        void Guardar(Paciente paciente);
    }
}
