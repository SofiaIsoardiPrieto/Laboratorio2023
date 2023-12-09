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
    public partial class FrmExamenAE : Form
    {

        private Examen examen;
        private readonly IServiciosExamenes _servicio;
        private bool esEdicion = false;
        public FrmExamenAE()
        {
            InitializeComponent();
            _servicio = new ServiciosExamenes();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (examen != null)
            {
               // ExamentextBox.Text = examen.Nombreexamen;
                esEdicion = true;
            }
        }
        public Examen GetExamen()
        {
            return examen;
        }
        public void SetExamen(Examen examen)
        {
            this.examen = examen;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (examen == null)
                {
                    examen = new Examen();
                }
                examen.NombreExamen = ExamentextBox.Text;
                try
                {
                    if (!_servicio.Existe(examen))
                    {
                        _servicio.Guardar(examen);

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
                            examen = null;
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
            ExamentextBox.Clear();
            ExamentextBox.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ExamentextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(ExamentextBox,
                    "Debe ingresar el nombre del examen/a");
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
        private void ExamentextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Se habilita el textbox pero se limpia grilla/lista y combos

        }
        private void ExamenDGV_MouseLeave(object sender, EventArgs e)
        {
            //ocultar el cartel quitar
        }
        private void ExamenDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //mostrar cartel quitar
        }
    }
}
