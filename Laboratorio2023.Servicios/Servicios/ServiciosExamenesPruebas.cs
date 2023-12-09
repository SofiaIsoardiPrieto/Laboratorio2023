using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosExamenesPruebas : IServiciosExamenesPruebas
    {
        private readonly IRepositorioExamenesPruebas _repositorio;
        public ServiciosExamenesPruebas()
        {
            _repositorio = new RepositorioExamenesPruebas();
        }

        public ExamenPrueba AddExamenPrueba(int examenId)
        {
            try
            {
                return _repositorio.AddExamenPrueba(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ExamenPrueba GetExamenEditado(int examenId, List<Prueba> listaPrueba)
        {
            try
            {
               return _repositorio.GetExamenEditado(examenId, listaPrueba);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Examen> GetExamenes()
        {
            try
            {
                return _repositorio.GetExamenes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
