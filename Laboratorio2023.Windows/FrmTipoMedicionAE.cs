using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Entidades.Entidades;
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
    public partial class FrmTipoMedicionAE : Form
    {

        private TipoMedicion tipoMedicion;
        private readonly IServiciosTipoMediciones _servicio;
        private bool esEdicion = false;
        public FrmTipoMedicionAE()
        {
            InitializeComponent();
            _servicio = new ServiciosTipoMediciones();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (tipoMedicion != null)
            {
                esEdicion = true;
            }
        }
       
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoMedicion == null)
                {
                    tipoMedicion = new TipoMedicion();
                }
                tipoMedicion.NombreMedicion = MediciontextBox.Text;            
                try
                {
                    if (!_servicio.Existe(tipoMedicion))
                    {
                        _servicio.Guardar(tipoMedicion);

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
                            tipoMedicion = null;
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
                        MessageBox.Show("Error al ingresar un tipo de medición, ya existe", "Mensaje",
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
            MediciontextBox.Clear();
            MediciontextBox.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(MediciontextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(MediciontextBox,
                    "Debe ingresar el nombre del tipo de rango");
            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetTipoMedicion(TipoMedicion tipoMedicion) => this.tipoMedicion = tipoMedicion;

        public TipoMedicion GetTipoMedicion() => tipoMedicion;
    }
}
