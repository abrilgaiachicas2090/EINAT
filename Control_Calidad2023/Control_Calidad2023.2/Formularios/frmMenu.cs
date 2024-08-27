using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Calidad2023.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario myForm = new frm_Usuario();
            myForm.ShowDialog();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorios myForm = new frmLaboratorios();
            myForm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados myForm = new frmEmpleados();
            myForm.ShowDialog();
        }

        private void lugarDeMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLugarMuestra myForm = new frmLugarMuestra();
            myForm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametros myForm = new frmParametros();
            myForm.ShowDialog();
        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnalisis myForm = new frmAnalisis();
            myForm.ShowDialog();
        }

        private void buscarMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarMuestra myForm = new frmBuscarMuestra();
            myForm.ShowDialog();

        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuestras myForm = new frmMuestras();
            myForm.ShowDialog();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmControlAcceso myForm = new frmControlAcceso();
            myForm.ShowDialog();
        }

        
    }
}
