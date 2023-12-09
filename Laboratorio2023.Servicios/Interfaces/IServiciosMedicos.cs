using Laboratorio2023.Entidades.Combos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosMedicos
    {
        bool Existe(MedicoCombo medico);
        List<MedicoCombo> GetMedicosCombo();
        void Guardar(MedicoCombo medico);
    }
}
