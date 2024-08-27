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
    public partial class frmBuscarMuestra : Form
    {
        public frmBuscarMuestra()
        {
            InitializeComponent();
        }

        #region Cargar Grilla
        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_BusquedaMuestra where Activo = 1";
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

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras
        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvBusquedaMuestra.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion


        #region Método que hace la búsqueda
        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_BusquedaMuestra where " + Campo
                + " like '%" + Buscado + "%'" + " and activo =1";
            //Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            //Evito que se generen nuevas columnas de maneta autom
            dgvBusquedaMuestra.AutoGenerateColumns = false;
            //Paso el resultado de la consulta a la grilla
            dgvBusquedaMuestra.DataSource = myDt;
        }
        #endregion

        private void txtBuscarLugardeMuestra_TextChanged(object sender, EventArgs e)
        {
            //Llamo al método que busca en tabla localidades y le paso
            //lo que el usuario escribió en el textBox de búsqueda como parámetro
            //y en qué campo de la tabla Localidades buscar
            BuscarRegistro(txtBuscarFecha.Text, "fecha");
        }

        private void txtBuscarMuestra_TextChanged(object sender, EventArgs e)
        {
            //Llamo al método que busca en tabla localidades y le paso
            //lo que el usuario escribió en el textBox de búsqueda como parámetro
            //y en qué campo de la tabla Localidades buscar
            BuscarRegistro(txtBuscarMuestra.Text, "lugar_muestra");
        }

        private void frmBuscarMuestra_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clsGlobales.myMuestraPublica.id_Muestra = Convert.ToInt32(dgvBusquedaMuestra.CurrentRow.Cells["id_Muestra"].Value);
            clsGlobales.myMuestraPublica.id_LugarMuestra = Convert.ToInt32(dgvBusquedaMuestra.CurrentRow.Cells["id_lugarmuestra"].Value);

            this.Close();
        }

        

        

        

        

    }
}
