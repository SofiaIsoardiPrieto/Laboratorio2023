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
    public class ServiciosMedicos:IServiciosMedicos
    {

        private readonly IRepositorioMedicos _repositorio;
        public ServiciosMedicos()
        {
            _repositorio = new RepositorioMedicos();
        }

        public bool Existe(MedicoCombo medico)
        {
            try
            {
                return _repositorio.Existe(medico);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MedicoCombo> GetMedicosCombo()
        {
            try
            {
                return _repositorio.GetMedicosCombo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(MedicoCombo medico)
        {
            try
            {
                if (medico.MedicoId == 0)
                {
                    _repositorio.Agregar(medico);
                }
                else
                {
                    _repositorio.Editar(medico);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
