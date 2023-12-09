using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmResultados : Form
    {
        private readonly IServiciosResultados _servicio;

        private List<ResultadoDto> lista;
        bool filtroON = false;
        string textoFiltro = null;
        DateTime fechaFiltro = DateTime.Today;
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 10;
        private List<ExamenPrueba> examenPruebas;
        private int protocoloId;

        public FrmResultados(int protocoloId, List<ExamenPrueba> examenPruebas)
        {
            InitializeComponent();
            _servicio = new ServiciosResultados();
            this.protocoloId = protocoloId;
            this.examenPruebas = examenPruebas;
        }
        private void FrmResultados_Load(object sender, EventArgs e)
        {
            _servicio.CrearAnalisis(protocoloId, examenPruebas);
            RecargarGrilla();

        }
        private void RecargarGrilla()
        {
            try
            {
                registro = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            
            lista = _servicio.GetResultadosDtoPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(ResultadoDGV);
            foreach (var cliente in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(ResultadoDGV);
                GridHelper.SetearFila(r, cliente);
                GridHelper.AgregarFila(ResultadoDGV, r);
            }
            Registroslabel.Text = registro.ToString();
            paginaActuallabel3.Text = paginaActual.ToString();
            paginasTotaleslabel5.Text = paginas.ToString();
            if (paginaActual == paginas)
            {
                siguientebutton.Enabled = false;
                ultimaPaginabutton4.Enabled = false;

            }
            if (paginaActual < paginas)
            {
                siguientebutton.Enabled = true;
                ultimaPaginabutton4.Enabled = true;

            }
            if (paginaActual == 1)
            {
                anteriorbutton2.Enabled = false;
                primeraPaginabutton1.Enabled = false;
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            FrmResultadoAE frm = new FrmResultadoAE();
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
            MostrarDatosEnGrilla();
        }
        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (ResultadoDGV.SelectedRows.Count == 0)
            {
                return;
            }
            var r = ResultadoDGV.SelectedRows[0];
            Resultado resultado = (Resultado)r.Tag;
            Resultado resultadoCopia = (Resultado)resultado.Clone();
            try
            {
                FrmResultadoAE frm = new FrmResultadoAE() { Text = "Editar Resultado" };
                frm.SetResultado(resultado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, resultadoCopia);
                    return;
                }
                resultado = frm.GetResultado();
                if (resultado != null)
                {
                    GridHelper.SetearFila(r, resultado);
                }
                else
                {
                    GridHelper.SetearFila(r, resultadoCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, resultadoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            if (ResultadoDGV.SelectedRows.Count == 0) return;
            var r = ResultadoDGV.SelectedRows[0];
            Resultado resultado = (Resultado)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicio.Borrar(resultado.ResultadoId);
                GridHelper.QuitarFila(ResultadoDGV, r);
                registro = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                Registroslabel.Text = registro.ToString();
                paginasTotaleslabel5.Text = paginas.ToString();
                MessageBox.Show("Resultado borrado exitosamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {

            textoFiltro = null;
            RecargarGrilla();
            //FiltrarResultadobutton.BackColor = colorOriginal;
            filtroON = false;
        }


       

       
        private void siguientebutton_Click(object sender, EventArgs e)
        {
            anteriorbutton2.Enabled = true;
            primeraPaginabutton1.Enabled = true;
            paginaActual++;
            if (paginaActual == paginas)
            {
                siguientebutton.Enabled = false;
                ultimaPaginabutton4.Enabled = false;

            }
            MostrarPaginado();
        }
        private void anteriorbutton2_Click(object sender, EventArgs e)
        {
            siguientebutton.Enabled = true;
            ultimaPaginabutton4.Enabled = true;
            paginaActual--;
            if (paginaActual == 1)
            {
                anteriorbutton2.Enabled = false;
                primeraPaginabutton1.Enabled = false;
            }
            MostrarPaginado();
        }
        private void primeraPaginabutton1_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            anteriorbutton2.Enabled = false;
            primeraPaginabutton1.Enabled = false;
            siguientebutton.Enabled = true;
            ultimaPaginabutton4.Enabled = true;
            MostrarPaginado();
        }
        private void ultimaPaginabutton4_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            siguientebutton.Enabled = false;
            ultimaPaginabutton4.Enabled = false;
            anteriorbutton2.Enabled = true;
            primeraPaginabutton1.Enabled = true;
            MostrarPaginado();
        }
        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultadoDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
