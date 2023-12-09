using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosExamenes:IServiciosExamenes
    {
        private readonly IRepositorioExamenes _repositorio;
        public ServiciosExamenes()
        {
            _repositorio = new RepositorioExamenes();
        }

        public void Borrar(int examenId)
        {
            try
            {
                _repositorio.Borrar(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int examenId)
        {
            try
            {
                return _repositorio.EstaRelacionado(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Examen examen)
        {
            try
            {
                return _repositorio.Existe(examen);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Examen> GetExamenesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetExamenesPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Examen examen)
        {
            try
            {
                if (examen.ExamenId == 0)
                {
                    _repositorio.Agregar(examen);
                }
                else
                {
                    _repositorio.Editar(examen);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
