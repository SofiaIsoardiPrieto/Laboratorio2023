using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
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
    public partial class FrmResultadoAE : Form
    {

        private Resultado resultado;
        private readonly IServiciosResultados _servicio;
        private bool esEdicion = false;
        public FrmResultadoAE()
        {
            InitializeComponent();
            _servicio = new ServiciosResultados();
           
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboHelper.CargarComboPruebas(ref PruebascomboBox);
            if (PruebascomboBox.SelectedIndex==0)
            {
                ResultadotextBox.Enabled = false;
            }
            else
            {
                ResultadotextBox.Enabled = true;
            }
            if (resultado != null)
            {
                PruebascomboBox.SelectedValue = resultado.ExamenesPruebasId;
                ResultadotextBox.Text = resultado.ResultadoPrueba;
                
                esEdicion = true;
            }
        }
        public Resultado GetResultado()
        {
            return resultado;
        }
        public void SetResultado(Resultado resultado)
        {
            this.resultado = resultado;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (resultado == null)
                {
                    resultado = new Resultado();
                }
                resultado.ExamenesPruebasId = (int)PruebascomboBox.SelectedValue;
                resultado.ResultadoPrueba = ResultadotextBox.Text;
               
                try
                {
                    if (!_servicio.Existe(resultado))
                    {
                        _servicio.Guardar(resultado);

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
                            resultado = null;
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
                        MessageBox.Show("Error al ingresar un resultado, ya existe", "Mensaje",
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
            ResultadotextBox.Clear();
            PruebascomboBox.SelectedIndex = 0;

        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ResultadotextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(ResultadotextBox,
                    "Debe ingresar el dato del resultado");
            }
            if (PruebascomboBox.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(PruebascomboBox,
                    "Debe seleccionar la nueva prueba a agregar");
                
            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
