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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pacientebutton_Click(object sender, EventArgs e)
        {
            FrmPacientes frm = new FrmPacientes();
            frm.ShowDialog();
        }

        private void Protocolobutton_Click(object sender, EventArgs e)
        {
            FrmProtocolos frm = new FrmProtocolos();
            frm.ShowDialog();
        }

        private void DatosTecnicosbutton_Click(object sender, EventArgs e)
        {
            FrmDatosTecnicos frm = new FrmDatosTecnicos();
            frm.ShowDialog();
        }

        private void NuevoAnalisisbutton_Click(object sender, EventArgs e)
        {
            FrmExamenPruebas frm =new FrmExamenPruebas();
            frm.ShowDialog();
        }
    }
}
