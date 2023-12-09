using Laboratorio2023.Entidades.Entidades;
using Laboratorio2023.Servicios.Interfaces;
using Laboratorio2023.Servicios.Servicios;
using Laboratorio2023.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace Laboratorio2023.Windows
{
    public partial class FrmDatosTecnicos : Form
    {
        public FrmDatosTecnicos()
        {
            InitializeComponent();  
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);           
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TiposRangosbutton_Click(object sender, EventArgs e)
        {
            FrmTipoRangos frm = new FrmTipoRangos();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void Rangosbutton_Click(object sender, EventArgs e)
        {
            FrmRangos frm = new FrmRangos();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void Medicionesbutton_Click(object sender, EventArgs e)
        {
            FrmTipoMediciones frm = new FrmTipoMediciones();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void Examenesbutton_Click(object sender, EventArgs e)
        {
            FrmExamenes frm = new FrmExamenes();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void Pruebasbutton_Click(object sender, EventArgs e)
        {
            FrmPruebas frm = new FrmPruebas();
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
