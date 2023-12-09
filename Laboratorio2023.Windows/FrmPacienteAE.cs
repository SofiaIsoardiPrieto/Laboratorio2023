using Laboratorio2023.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
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
    public partial class FrmPacienteAE : Form
    {

        private Paciente paciente;
        private readonly IServiciosPacientes _servicio;
        private bool esEdicion = false;
        public FrmPacienteAE()
        {
            InitializeComponent();
            _servicio = new ServiciosPacientes();
           
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (paciente != null)
            {
                NombretextBox.Text = paciente.Nombre;
                ApellidotextBox.Text = paciente.Apellido;
                TelefonotextBox.Text = paciente.Telefono;
                if (paciente.Sexo == "Femenino")
                {
                    FemeninoradioButton.Checked = true;
                }
                else if (paciente.Sexo == "Masculino")
                {
                    MasculinoradioButton.Checked = true;
                }
                FechaTimePicker.Value = paciente.FechaNacimiento;
                esEdicion = true;
            }
        }
        public Paciente GetPaciente()
        {
            return paciente;
        }
        public void SetPaciente(Paciente paciente)
        {
            this.paciente = paciente;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (paciente == null)
                {
                    paciente = new Paciente();
                }
                paciente.Nombre = NombretextBox.Text;
                paciente.Apellido = ApellidotextBox.Text;
                paciente.Telefono = TelefonotextBox.Text;
                if (FemeninoradioButton.Checked)
                {
                    paciente.Sexo = "Femenino";
                }
                else
                {
                    paciente.Sexo = "Masculino";
                }
                paciente.FechaNacimiento = FechaTimePicker.Value;
                try
                {
                    if (!_servicio.Existe(paciente))
                    {
                        _servicio.Guardar(paciente);

                        if (!esEdicion)
                        {
                            MessageBox.Show("Registro ingresado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("¿Desea agregar otro registro?",
                                 "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;
                                return;
                            }
                            paciente = null;
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
                        MessageBox.Show("Error al ingresar un paciente, ya existe", "Mensaje",
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
            NombretextBox.Clear();
            NombretextBox.Focus();
            ApellidotextBox.Clear();
            TelefonotextBox.Clear();
            FemeninoradioButton.Checked=true;
            FechaTimePicker.Value = DateTime.Now;

        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(NombretextBox,
                    "Debe ingresar el nombre del paciente");
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(ApellidotextBox,
                    "Debe ingresar el apellido del paciente");
            }
            if (!(FemeninoradioButton.Checked || MasculinoradioButton.Checked))
            {
                validez = false;
                errorProvider1.SetError(ApellidotextBox,
                    "Debe ingresar el sexo del paciente");
            }
            if (FechaTimePicker.Value.Year>DateTime.Now.Year)
            {
                validez = false;
                errorProvider1.SetError(FechaTimePicker,
                    "Fecha no válida");
                
            }
            return validez;
        }
       
        

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
