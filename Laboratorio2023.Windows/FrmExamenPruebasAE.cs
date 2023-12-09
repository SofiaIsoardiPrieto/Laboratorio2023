using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmExamenPruebasAE : Form
    {
        private readonly IServiciosExamenesPruebas _servicio;
        private readonly IServiciosPruebas _serviciopruebas;

        private List<PruebaCombo> listaprueba;
        private Examen examen;
        private ExamenPrueba examenPrueba;
        public FrmExamenPruebasAE(Examen examenIdAEditar)
        {
            InitializeComponent();
            _servicio = new ServiciosExamenesPruebas();
            _serviciopruebas = new ServiciosPruebas();
            examen = examenIdAEditar;
        }
        private void FrmExamenes_Load(object sender, EventArgs e)
        {
            MostrarDatosEnGrilla();
            
        }
        private void MostrarDatosEnGrilla()
        {
            listaprueba = _serviciopruebas.GetPruebaCombo(examen.ExamenId);
            GridHelper.LimpiarGrilla(ExamenEditDGV);
            foreach (var prueba in listaprueba)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(ExamenEditDGV);
                GridHelper.SetearFila(r, prueba);
                GridHelper.AgregarFila(ExamenEditDGV, r);
            }
        }
       
       
        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            //Quitar prueba del examen
            if (ExamenEditDGV.SelectedRows.Count == 0) { return; }
            var r = ExamenEditDGV.SelectedRows[0];
            PruebaCombo prueba = (PruebaCombo)r.Tag;
            GridHelper.QuitarFila(ExamenEditDGV, r);
            listaprueba.Remove(prueba);
        }
        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            //Dejar la lista de pruebas completas
            MostrarDatosEnGrilla();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //Cuando esta la lista de examenes elegidos y editados
          
            List<Prueba> listaPrueba = listaprueba.Select(pc => new Prueba { PruebaId = pc.PruebaId, NombrePrueba = pc.NombrePrueba }).ToList();
            examenPrueba = _servicio.GetExamenEditado(examen.ExamenId, listaPrueba);
            DialogResult = DialogResult.OK;
        }
        
        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ExamenPrueba GetExamenEditado()=>examenPrueba;
        
    }
}
