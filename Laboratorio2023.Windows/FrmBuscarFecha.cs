using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmBuscarFecha : Form
    {
        public FrmBuscarFecha()
        {
            InitializeComponent();
        }

        private DateTime fechaFiltro;
        public DateTime GetFecha()
        {
            return fechaFiltro;
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                fechaFiltro = BuscarFechaTimePicker.Value;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            
            DateTime fechaSeleccionada = BuscarFechaTimePicker.Value;
            if (fechaSeleccionada.Day > DateTime.Today.Day && fechaSeleccionada.Month > DateTime.Today.Month && fechaSeleccionada.Year > DateTime.Today.Year)
            {
                errorProvider1.SetError(BuscarFechaTimePicker, "La fecha no puede ser posterior a hoy.");
                validez = false;
            }

            return validez;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
