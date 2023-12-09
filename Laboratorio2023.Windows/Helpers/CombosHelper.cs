using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using System.Windows.Forms;

namespace Laboratorio2023.Windows.Helpers
{
    public static class ComboHelper
    {
        public static void CargarComboPruebas(ref ComboBox combo)
        {
            IServiciosPruebas serviciosPruebas = new ServiciosPruebas();
            var lista = serviciosPruebas.GetPruebaCombo(null);
            var defaultPrueba = new PruebaCombo()
            {
                PruebaId = 0,
                NombrePrueba = "Seleccione Prueba"

            };
            lista.Insert(0, defaultPrueba);
            combo.DataSource = lista;
            combo.DisplayMember = "NombrePrueba";
            combo.ValueMember = "PruebaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboPacientes(ref ComboBox combo)
        {
            IServiciosPacientes serviciosPacientes = new ServiciosPacientes();
            var lista = serviciosPacientes.GetPacientesCombo();
            var defaultPaciente = new PacienteCombo()
            {
                PacienteId = 0,
                NombreCompleto = "Seleccione Paciente"

            };
            lista.Insert(0, defaultPaciente);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCompleto";
            combo.ValueMember = "PacienteId";
            combo.SelectedIndex = 0;
        }

        internal static void CargarComboMedicos(ref ComboBox combo)
        {
            IServiciosMedicos serviciosMedicos = new ServiciosMedicos();
            var lista = serviciosMedicos.GetMedicosCombo();
            var defaultMedico = new MedicoCombo()
            {
                MedicoId = 0,
                NombreMedico = "Seleccione Medico"

            };
            lista.Insert(0, defaultMedico);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreMedico";
            combo.ValueMember = "MedicoId";
            combo.SelectedIndex = 0;
        }
    }
}
