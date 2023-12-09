using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
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
    public partial class FrmTipoRangoAE : Form
    {

        private TipoRango tipoRango;
        private readonly IServiciosTipoRangos _servicio;
        private bool esEdicion = false;
        public FrmTipoRangoAE()
        {
            InitializeComponent();
            _servicio = new ServiciosTipoRangos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (tipoRango != null)
            {
                esEdicion = true;
            }
        }
       
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoRango == null)
                {
                    tipoRango = new TipoRango();
                }
                tipoRango.NombreTipoRango = TipoRangotextBox.Text;            
                try
                {
                    if (!_servicio.Existe(tipoRango))
                    {
                        _servicio.Guardar(tipoRango);

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
                            tipoRango = null;
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
                        MessageBox.Show("Error al ingresar un tipo de rango, ya existe", "Mensaje",
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
            TipoRangotextBox.Clear();
            TipoRangotextBox.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoRangotextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(TipoRangotextBox,
                    "Debe ingresar el nombre del tipo de rango");
            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal TipoRango GetTipoRango()
        {
            throw new NotImplementedException();
        }

        internal void SetTipoRango(TipoRango tipoRango)
        {
            throw new NotImplementedException();
        }
    }
}
