using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Interfaces
{
    public interface IServiciosExamenesPruebas
    {
        ExamenPrueba GetExamenEditado(int examenId, List<Prueba> listaprueba);
    }
}
