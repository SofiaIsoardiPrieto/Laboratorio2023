using Laboratorio2023.Entidades.Combos;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioMedicos
    {
        void Agregar(MedicoCombo medico);
        void Editar(MedicoCombo medico);
        bool Existe(MedicoCombo medico);
        List<MedicoCombo> GetMedicosCombo();
    }
}
