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
    public partial class FrmRangoAE : Form
    {

        private Rango rango;
        private readonly IServiciosRangos _servicio;
        private bool esEdicion = false;
        public FrmRangoAE()
        {
            InitializeComponent();
            _servicio = new ServiciosRangos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (rango != null)
            {
               
                esEdicion = true;
            }
        }
        public Rango GetRango()
        {
            return rango;
        }
        public void SetRango(Rango rango)
        {
            this.rango = rango;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rango == null)
                {
                    rango = new Rango();
                }
                
                try
                {
                    if (!_servicio.Existe(rango))
                    {
                        _servicio.Guardar(rango);

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
                            rango = null;
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
                        MessageBox.Show("Error al ingresar un rango, ya existe", "Mensaje",
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
           
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NuevoTipoRangobutton_Click(object sender, EventArgs e)
        {
            FrmTipoRangoAE frm = new FrmTipoRangoAE();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void NuevaPruebabutton_Click(object sender, EventArgs e)
        {
            //DialogResult draa = frm.ShowDialog(this);
        }

        private void NuevoExamenbutton_Click(object sender, EventArgs e)
        {
            FrmExamenAE frm = new FrmExamenAE();
            DialogResult draa = frm.ShowDialog(this);
        }

      
    }
}
