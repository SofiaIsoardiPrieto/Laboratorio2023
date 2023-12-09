using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioPacientes
    {
        void Agregar(Paciente paciente);
        void Borrar(int pacienteId);
        void Editar(Paciente paciente);
        bool Existe(Paciente paciente);
        int GetCantidad(string textoFiltro = null);
        List<PacienteCombo> GetPacientesCombo();
        List<Paciente> GetPacientesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null);

    }
}
