using Laboratorio2023.Entidades.Dtos;
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
    public partial class FrmProtocolos : Form
    {
        private readonly IServiciosProtocolos _servicio;

        private List<Protocolo> lista;
        bool filtroON = false;
        string textoFiltro = null;
        DateTime fechaFiltro = DateTime.Today;
        private Color colorOriginal;
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 10;

        public FrmProtocolos()
        {
            InitializeComponent();
            _servicio = new ServiciosProtocolos();
        }
        private void FrmProtocolos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                registro = _servicio.GetCantidad(null, null);
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            lista = _servicio.GetProtocolosPorPagina(registrosPorPagina, paginaActual, null, null);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(ProtocoloDGV);
            foreach (var protocolo in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(ProtocoloDGV);
                GridHelper.SetearFila(r, protocolo);
                GridHelper.AgregarFila(ProtocoloDGV, r);
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
        //private void Nuevobutton_Click(object sender, EventArgs e)
        //{
        //    FrmProtocoloAE frm = new FrmProtocoloAE(_servicio);
        //    DialogResult dr = frm.ShowDialog(this);
        //    RecargarGrilla();
        //    MostrarDatosEnGrilla();
        //}
        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (ProtocoloDGV.SelectedRows.Count == 0)
            {
                return;
            }
            var r = ProtocoloDGV.SelectedRows[0];
            Protocolo protocolo = (Protocolo)r.Tag;
            Protocolo protocoloViejo = (Protocolo)protocolo.Clone();
            try
            {
                FrmProtocoloAE frm = new FrmProtocoloAE(null) { Text = "Editar Protocolo" };
                frm.SetProtocolo(protocolo);
                DialogResult dr = frm.ShowDialog(this);


                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, protocoloViejo);
                    return;
                }
                protocolo = frm.GetProtocolo();
                if (protocolo != null)
                {
                    GridHelper.SetearFila(r, protocolo);
                }
                else
                {
                    GridHelper.SetearFila(r, protocoloViejo);

                }
                RecargarGrilla();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //para borrar primero tengo que borrar todos los resultados asociados a ese ProtocoloId
        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            if (ProtocoloDGV.SelectedRows.Count == 0) return;
            var r = ProtocoloDGV.SelectedRows[0];
            Protocolo protocolo = (Protocolo)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                if (!_servicio.EstaRelacionado(protocolo.ProtocoloId))
                {
                    _servicio.Borrar(protocolo.ProtocoloId);
                    GridHelper.QuitarFila(ProtocoloDGV, r);
                    registro = _servicio.GetCantidad(null, null);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    Registroslabel.Text = registro.ToString();
                    paginasTotaleslabel5.Text = paginas.ToString();
                    MessageBox.Show("Protocolo borrado exitosamente", "Mensaje",
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

        private void FiltrarPacientebutton_Click(object sender, EventArgs e)
        {
            colorOriginal = FiltrarPacientebutton.BackColor;
            if (!filtroON)
            {
                FrmBuscarNombre frm = new FrmBuscarNombre { Text = "Buscar Protocolos" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    textoFiltro = frm.GetTexto();
                    registro = _servicio.GetCantidad(textoFiltro, fechaFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetProtocolosPorPagina(registrosPorPagina, paginaActual, textoFiltro, null);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay Pacientes con esa letra/texto", "Informacion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    FiltrarPacientebutton.BackColor = Color.Gray;
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

        private void FiltrarFechabutton_Click(object sender, EventArgs e)
        {
            colorOriginal = FiltrarFechabutton.BackColor;
            if (!filtroON)
            {
                FrmBuscarFecha frm = new FrmBuscarFecha();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    fechaFiltro = frm.GetFecha();
                    registro = _servicio.GetCantidad(textoFiltro, fechaFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetProtocolosPorPagina(registrosPorPagina, paginaActual, null, fechaFiltro);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay análisis realizadas en esa fecha", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    FiltrarFechabutton.BackColor = Color.Gray;
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
            FiltrarPacientebutton.BackColor = colorOriginal;
            FiltrarFechabutton.BackColor = colorOriginal;
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
