using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmProtocoloAE : Form
    {

        private Protocolo protocolo;
        private readonly IServiciosProtocolos _servicio;
        private bool esEdicion = false;
        private List<ExamenPrueba> examenPruebas;
        public FrmProtocoloAE(List<ExamenPrueba> examenPruebas)
        {
            InitializeComponent();
            _servicio = new ServiciosProtocolos();
            this.examenPruebas = examenPruebas;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboHelper.CargarComboPacientes(ref PacientescomboBox);
            ComboHelper.CargarComboMedicos(ref MedicocomboBox);
            if (protocolo != null)
            {
                PacientescomboBox.SelectedValue = protocolo.PacienteId;
                FechaTimePicker.Value = protocolo.FechaRealizacion;
                MedicocomboBox.SelectedValue = protocolo.MedicoId;
                esEdicion = true;
            }
        }
        public Protocolo GetProtocolo()
        {
            return protocolo;
        }
        public void SetProtocolo(Protocolo protocolo)
        {
            this.protocolo = protocolo;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (protocolo == null)
                {
                    protocolo = new Protocolo();
                }
                protocolo.PacienteId = (int)PacientescomboBox.SelectedValue;
                protocolo.FechaRealizacion = FechaTimePicker.Value;
                protocolo.MedicoId = (int)MedicocomboBox.SelectedValue;

                try
                {
                    if (!_servicio.Existe(protocolo))
                    {
                        _servicio.Guardar(protocolo);

                        if (!esEdicion)
                        {
                            MessageBox.Show("Registro ingresado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmResultados frm = new FrmResultados(protocolo.ProtocoloId,examenPruebas);
                            DialogResult = DialogResult.OK;
                            protocolo = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Registro editado exitosamente", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar un protocolo, ya existe", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicializarControles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InicializarControles()
        {
            FechaTimePicker.Value = DateTime.Today;
            PacientescomboBox.SelectedIndex = 0;
            MedicocomboBox.SelectedIndex = 0;

        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (MedicocomboBox.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(MedicocomboBox,
                    "Debe seleccionar un médico");

            }
            if (PacientescomboBox.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(PacientescomboBox,
                    "Debe seleccionar un paciente");

            }
            DateTime fechaSeleccionada = FechaTimePicker.Value;
            if (fechaSeleccionada.Day > DateTime.Today.Day && fechaSeleccionada.Month > DateTime.Today.Month && fechaSeleccionada.Year > DateTime.Today.Year)
            {
                errorProvider1.SetError(FechaTimePicker, "La fecha no puede ser posterior a hoy.");
                validez = false;
            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NuevaPacientebutton_Click(object sender, EventArgs e)
        {
            FrmPacienteAE frm = new FrmPacienteAE();
            DialogResult draa = frm.ShowDialog(this);
            ComboHelper.CargarComboPacientes(ref PacientescomboBox);
        }

        private void NuevoMedicobutton_Click(object sender, EventArgs e)
        {
            FrmMedicoAE frm = new FrmMedicoAE();
            DialogResult dree = frm.ShowDialog(this);
            if (dree == DialogResult.OK)
            {
                ComboHelper.CargarComboMedicos(ref MedicocomboBox);

            }
        }
    }
}
