using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Datos.Repositorios;
using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Servicios.Servicios
{
    public class ServiciosPacientes:IServiciosPacientes
    {
        private readonly IRepositorioPacientes _repositorio;
        public ServiciosPacientes()
        {
            _repositorio = new RepositorioPacientes();
        }

        public void Borrar(int pacienteId)
        {
            try
            {
                _repositorio.Borrar(pacienteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Paciente paciente)
        {
            try
            {
                return _repositorio.Existe(paciente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro=null)
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

        

        public List<Paciente> GetPacientesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetPacientesPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PacienteCombo> GetPacientesCombo()
        {
            try
            {
                return _repositorio.GetPacientesCombo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Paciente paciente)
        {
            try
            {
                if (paciente.PacienteId == 0)
                {
                    _repositorio.Agregar(paciente);
                }
                else
                {
                    _repositorio.Editar(paciente);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
