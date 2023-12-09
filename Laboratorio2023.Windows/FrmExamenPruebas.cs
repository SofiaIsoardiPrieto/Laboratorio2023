using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmExamenPruebas : Form
    {
        private readonly ServiciosExamenesPruebas _servicio;

        private List<Examen> lista;
        private List<Examen> listaAgregados;
        private List<ExamenPrueba> examenPruebas;
        public FrmExamenPruebas()
        {
            InitializeComponent();
            _servicio = new ServiciosExamenesPruebas();
            listaAgregados = new List<Examen>();
            examenPruebas = new List<ExamenPrueba>();
        }
        private void FrmProtocolos_Load(object sender, EventArgs e)
        {
            MostrarDatosEnGrilla();
            
        }
        private void MostrarDatosEnGrilla()
        {
            lista = _servicio.GetExamenes();
            
            GridHelper.LimpiarGrilla(ExamenDGV);
            foreach (var examen in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(ExamenDGV);
                GridHelper.SetearFila(r, examen);
                GridHelper.AgregarFila(ExamenDGV, r);
            }
        }
        private void MostrarDatosEnGrillaDeAgregados()
        {
            foreach (var examen in listaAgregados)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(AgregadoDGV);
                GridHelper.SetearFila(r, examen);
                GridHelper.AgregarFila(AgregadoDGV, r);
            }
        }
        private void AgregarExamenbutton_Click(object sender, EventArgs e)
        {
            //pasar de examen a examen agregado
            
            if (ExamenDGV.SelectedRows.Count == 0) { return; }
            var r = ExamenDGV.SelectedRows[0];

            Examen examenElegido = (Examen)r.Tag;


            examenPruebas.Add(_servicio.AddExamenPrueba(examenElegido.ExamenId));

            GridHelper.QuitarFila(ExamenDGV, r);
            GridHelper.AgregarFila(AgregadoDGV, r);

            MostrarDatosEnGrillaDeAgregados();

        }
        private void EditarExamenbutton_Click(object sender, EventArgs e)
        {
            //Donde edito? antes o despues, para quitar pruebas
            if (ExamenDGV.SelectedRows.Count == 0) { return; }
            var r = ExamenDGV.SelectedRows[0];
            Examen examenIdAEditar = (Examen)r.Tag;
            FrmExamenPruebasAE frm = new FrmExamenPruebasAE(examenIdAEditar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; };

            GridHelper.QuitarFila(ExamenDGV, r);
            GridHelper.AgregarFila(AgregadoDGV, r);
            examenPruebas.Add(frm.GetExamenEditado());
            MostrarDatosEnGrillaDeAgregados();
        }
        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            //Quitar examen de la lista agregadas
            if (AgregadoDGV.SelectedRows.Count == 0) { return; }
            var r = AgregadoDGV.SelectedRows[0];
            Examen examenIdAEliminar = (Examen)r.Tag;


            //examenPruebas.Remove(_servicio.RemoveExamenPrueba(examenElegido.ExamenId));
            examenPruebas.RemoveAll(examenPruebas => examenPruebas.ExamenId == examenIdAEliminar.ExamenId);
            GridHelper.QuitarFila(AgregadoDGV, r);
            GridHelper.AgregarFila(ExamenDGV, r);


            MostrarDatosEnGrillaDeAgregados();

        }
        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            //Si quiero limpiar la lista de examenes elegidos y empezar de nuevo
            examenPruebas.Clear();
            listaAgregados.Clear();
            MostrarDatosEnGrilla();
            GridHelper.LimpiarGrilla(AgregadoDGV);
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //Cuando esta la lista de examenes elegidos y editados
            FrmProtocoloAE frm = new FrmProtocoloAE(examenPruebas);
            DialogResult dr = frm.ShowDialog(this);
        }
        public List<ExamenPrueba> GetListaAprobada()
        {
            return examenPruebas;
        }
        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
