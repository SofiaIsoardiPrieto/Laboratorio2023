
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Entidades;
using System.Collections.Generic;

namespace Laboratorio2023.Datos.Infertaces
{
    public interface IRepositorioExamenesPruebas
    {
        ExamenPrueba AddExamenPrueba(int examenId);
        ExamenPrueba GetExamenEditado(int examenId, List<Prueba> listaPrueba);
        List<Examen> GetExamenes();
        
    }
}
