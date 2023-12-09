using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Dtos;
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
    public partial class FrmTipoMediciones : Form
    {
        private readonly IServiciosTipoMediciones _servicio;

        private List<TipoMedicion> lista;
        bool filtroON = false;
        string textoFiltro = null;
        private Color colorOriginal;
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 10;
        
        public FrmTipoMediciones()
        {
            InitializeComponent();
            _servicio = new ServiciosTipoMediciones();
        }
        private void FrmTipoMediciones_Load(object sender, EventArgs e)
        {
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
            lista = _servicio.GetTipoMedicionesPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(TipoMedicionesDGV);
            foreach (var cliente in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(TipoMedicionesDGV);
                GridHelper.SetearFila(r, cliente);
                GridHelper.AgregarFila(TipoMedicionesDGV, r);
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
            FrmTipoMedicionAE frm = new FrmTipoMedicionAE();
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
            MostrarDatosEnGrilla();
        }
        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (TipoMedicionesDGV.SelectedRows.Count == 0)
            {
                return;
            }
            var r = TipoMedicionesDGV.SelectedRows[0];
            TipoMedicion tipoMedicion = (TipoMedicion)r.Tag;
            TipoMedicion tipoMedicionCopia = (TipoMedicion)tipoMedicion.Clone();
            try
            {
                FrmTipoMedicionAE frm = new FrmTipoMedicionAE() { Text = "Editar TipoMedicion" };
                frm.SetTipoMedicion(tipoMedicion);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, tipoMedicionCopia);
                    return;
                }
                tipoMedicion = frm.GetTipoMedicion();
                if (tipoMedicion != null)
                {
                    GridHelper.SetearFila(r, tipoMedicion);
                }
                else
                {
                    GridHelper.SetearFila(r, tipoMedicionCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, tipoMedicionCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            if (TipoMedicionesDGV.SelectedRows.Count == 0) return;
            var r = TipoMedicionesDGV.SelectedRows[0];
            TipoMedicion tipoMedicion = (TipoMedicion)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                if (!_servicio.EstaRelacionado(tipoMedicion.TipoMedicionId))
                {
                    _servicio.Borrar(tipoMedicion.TipoMedicionId);
                    GridHelper.QuitarFila(TipoMedicionesDGV, r);
                    registro = _servicio.GetCantidad();
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    Registroslabel.Text = registro.ToString();
                    paginasTotaleslabel5.Text = paginas.ToString();
                    MessageBox.Show("TipoMedicion borrada exitosamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                    MostrarDatosEnGrilla(); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Filtrarbutton_Click(object sender, EventArgs e)
        {

            colorOriginal = Filtrarbutton.BackColor;
            if (!filtroON)
            {
                FrmBuscarNombre frm = new FrmBuscarNombre { Text = "Buscar TipoMediciones" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    textoFiltro = frm.GetTexto();
                    registro = _servicio.GetCantidad(textoFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetTipoMedicionesPorPagina(registrosPorPagina, paginaActual, textoFiltro);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay TipoMediciones con esa letra/texto", "Informacion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Filtrarbutton.BackColor = Color.Gray;
                    filtroON = true;
                    MostrarDatosEnGrilla();
                }

                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Limpie el filtro activo (Actualizar)", "Adevertencia",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
           
            textoFiltro = null;
            RecargarGrilla();
            Filtrarbutton.BackColor = colorOriginal;
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
    }
}
