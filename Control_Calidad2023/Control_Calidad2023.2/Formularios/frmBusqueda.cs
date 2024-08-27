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
    public partial class frmBusqueda_Muestra : Form
    {
        public frmBusqueda_Muestra()
        {
            InitializeComponent();
        }

        #region Cargar Grilla
        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_Analisis1 where activo = 1";
            //Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            //Oculto las columnas que sobran de la grilla
            dgvBusquedaMuestra.AutoGenerateColumns = false;
            //Paso el resultado de la consulta a la grila
            dgvBusquedaMuestra.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }
        #endregion

        #region Método que hace la búsqueda
        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_Muestras where " + Campo
                + " like '%" + Buscado + "%'" + " and activo =1";
            //Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            //Evito que se generen nuevas columnas de maneta autom
            dgvBusquedaMuestra.AutoGenerateColumns = false;
            //Paso el resultado de la consulta a la grilla
            dgvBusquedaMuestra.DataSource = myDt;
        }

        #region Eventos de la búsqueda
        private void txtBuscarFechaMuestra_TextChanged(object sender, EventArgs e)
        {
            //Llamo al método que busca en tabla localidades y le paso
            //lo que el usuario escribió en el textBox de búsqueda como parámetro
            //y en qué campo de la tabla Localidades buscar
            BuscarRegistro(txtBuscarFechaMuestra.Text, "fecha");
        }

        private void txtBuscarLugarMuestra_TextChanged(object sender, EventArgs e)
        {
            //Llamo al método que busca en tabla localidades y le paso
            //lo que el usuario escribió en el textBox de búsqueda como parámetro
            //y en qué campo de la tabla Localidades buscar
            BuscarRegistro(txtBuscarLugarMuestra.Text, "lugar_muestra");
        }

        private void txtBuscarFechaMuestra_Enter(object sender, EventArgs e)
        {
            txtBuscarFechaMuestra.Text = "";
        }

        private void txtBuscarLugarMuestra_Enter(object sender, EventArgs e)
        {
            txtBuscarLugarMuestra.Text = "";
        }
        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras
        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvBusquedaMuestra.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Llamo a las propiedades del objeto con los datos de la fila actual de la grilla
            clsGlobales.myAnalisisPublico.id_Muestra = Convert.ToInt32(dgvBusquedaMuestra.CurrentRow.Cells["id_Muestra"].Value);
            clsGlobales.myAnalisisPublico.fecha = Convert.ToDateTime(dgvBusquedaMuestra.CurrentRow.Cells["fecha"].Value);
            clsGlobales.myAnalisisPublico.lugar_muestra = Convert.ToString(dgvBusquedaMuestra.CurrentRow.Cells["lugar_muestra"].Value);
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpbBusquedaMuestra_Enter(object sender, EventArgs e)
        {

        }
    }
}
        #endregion