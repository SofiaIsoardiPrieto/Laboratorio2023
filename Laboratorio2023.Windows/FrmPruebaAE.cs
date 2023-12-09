using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
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
    public partial class FrmPruebaAE : Form
    {

        private MedicoCombo medico;
        private readonly IServiciosMedicos _servicio;
        private bool esEdicion = false;
        public FrmPruebaAE()
        {
            InitializeComponent();
            _servicio = new ServiciosMedicos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (medico != null)
            {
                PruebatextBox.Text = medico.NombreMedico;
                esEdicion = true;
            }
        }
        public MedicoCombo GetMedico()
        {
            return medico;
        }
        public void SetMedico(MedicoCombo medico)
        {
            this.medico = medico;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (medico == null)
                {
                    medico = new MedicoCombo();
                }
                medico.NombreMedico = PruebatextBox.Text.ToUpper();
                try
                {
                    if (!_servicio.Existe(medico))
                    {
                        _servicio.Guardar(medico);

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
                            medico = null;
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
                        MessageBox.Show("Error al ingresar un médico/a, ya existe", "Mensaje",
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
            PruebatextBox.Clear();
            PruebatextBox.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PruebatextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(PruebatextBox,
                    "Debe ingresar el nombre del medico/a");
            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Pacientebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void PruebaDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //para quitar una prueba ingresada erronamente
            //QuitarDobleClickLabel
        }

        private void PruebacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar esa prueba a la grilla
        }

        private void NuevaPruebabutton_Click(object sender, EventArgs e)
        {
            //Nueva prueba
        }

        

        private void NuevoRangobutton_Click(object sender, EventArgs e)
        {
            //nuevo rango

        }

        private void PruebaDGV_MouseLeave(object sender, EventArgs e)
        {
            QuitarDobleClickLabel.Visible = false;
        }

        private void PruebaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuitarDobleClickLabel.Visible = true;
        }

        private void PruebatextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Habilitarlo si hubo un error al escribil la prueba
            //pero entonces se limpia la grilla y los combos
        }

        internal void SetPrueba(PruebaDto pruebaDto)
        {
            throw new NotImplementedException();
        }

        internal PruebaDto GetPrueba()
        {
            throw new NotImplementedException();
        }
    }
}
