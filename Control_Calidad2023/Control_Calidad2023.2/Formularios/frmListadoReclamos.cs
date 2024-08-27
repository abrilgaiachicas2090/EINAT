using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad_2023.Clases;

namespace Control_Calidad_2023.Formularios
{
    public partial class frmListadoReclamos : Form
    {

        #region Varaible del formulario
        clsListado_Reclamos myListadoReclamo = new clsListado_Reclamos();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region constructor del formulario
        public frmListadoReclamos()
        {
            InitializeComponent();
        }
        #endregion

        #region metodos

        #region Método que activa los botones del formulario

        private void ActivarBotones()
        {
            // Pregunto a la variable que está haciendo el usuario
            switch (sEstado)
            {
                // Si está haciendo un alta
                case "A":

                    btnModificar.Visible = false;
                    btnBuscar.Visible = false;

                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    btnSalir.Visible = false;

                    break;

                // Si está buscando
                case "B":
                    btnModificar.Visible = false;
                    btnBuscar.Visible = false;

                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    btnSalir.Visible = false;

                    break;

                // Si no está haciendo nada
                case "C":
                    btnModificar.Visible = true;
                    btnBuscar.Visible = true;

                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;

                    btnSalir.Visible = true;

                    break;

                // Si está modificando
                case "M":
                    btnModificar.Visible = false;
                    btnBuscar.Visible = false;

                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    btnSalir.Visible = false;

                    break;
            }
        }

        #endregion

        #region Método que habilita los controles del Formulario

        private void HabilitarControles()
        {
            // Pregunto a la variable que está haciendo el usuario
            switch (sEstado)
            {

                // Si está buscando
                case "B":
                    cboEstadoReclamo.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvListadoReclamos.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    cboEstadoReclamo.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvListadoReclamos.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    cboEstadoReclamo.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvListadoReclamos.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarCodCliente.Text = "";
            txtEstadoReclamo.Text = "";
        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_ListadoReclamos where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvListadoReclamos.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvListadoReclamos.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvListadoReclamos.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_ListadoReclamos where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvListadoReclamos.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvListadoReclamos.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myListadoReclamo.id_EstadoReclamo = Convert.ToInt32(dgvListadoReclamos.CurrentRow.Cells["id_EstadoReclamo"].Value);
            myListadoReclamo.id_ListadoReclamos = Convert.ToInt32(dgvListadoReclamos.CurrentRow.Cells["id_ListadoReclamo"].Value);
            myListadoReclamo.id_Reclamos = Convert.ToInt32(dgvListadoReclamos.CurrentRow.Cells["id_Reclamos"].Value);          
        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            cboEstadoReclamo.SelectedValue = Convert.ToString(myListadoReclamo.id_EstadoReclamo);
        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtEstadoReclamo.Text = "";
            txtBuscarCodCliente.Text = "";
            // Ubico el foco en el primer control
            cboEstadoReclamo.Focus();

        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase
            myListadoReclamo.id_EstadoReclamo = Convert.ToInt32(cboEstadoReclamo.SelectedValue);

        }


        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //Limpiar los campos de busqueda
            LimpiarBusqueda();
            // Cargar la grilla con los datos desde la BD
            CargarGrilla();

        }
        #endregion

        #endregion

        #region eventos

        #region evento LOAD

        private void frmListadoReclamos_Load(object sender, EventArgs e)                 
        {
            // Cargo el combo
            Control_Calidad2023.Clases.clsMetodos.CargarComboWhere(cboEstadoReclamo, "EstadoReclamos", "EstadoReclamo", "id_EstadoReclamo", "activo = 1");
            CargarFormulario();

        }

        #endregion

        #region evento TextChanged

        private void frmListadoReclamos_TextChanged(object sender, EventArgs e)
        {
            //// Paso los datos de la grilla al objeto
            //GrillaAObjeto();
            //// Paso los datos del objeto a los controles
            //ObjetoAControles();
        }

        #endregion

        #region evento SelectionChanged

        private void dgvListadoReclamos_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }

        #endregion

        #region TextChanged Buscar cod_cliente
        private void txtBuscarCodCliente_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarCodCliente.Text, "cod_cliente");
        }
        #endregion

        #region TextChanged buscar Estado Reclamo
        private void txtEstadoReclamo_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtEstadoReclamo.Text, "EstadoReclamo");
        }
        #endregion

        #region Eventos de los botones

        #region Evento click boton Aceptar

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_ListadoReclamo = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myListadoReclamo.cValidaListadoReclamos() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myListadoReclamo.id_EstadoReclamo == 0)
            {
                // muestro un mensaje indicando que faltan datos
                MessageBox.Show("Debe completar todos los datos !!! ", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // retornar 
                return;
            }
            // dependiendo de lo que esta haciendo el usuario
            switch (sEstado)
            {
                

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_ListadoReclamo = Convert.ToInt32(dgvListadoReclamos.CurrentRow.Cells["id_Reclamo"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update Listado_Reclamos  set id_Reclamos = " + myListadoReclamo.id_Reclamos + ","
                        + "id_EstadoReclamo = " + myListadoReclamo.id_EstadoReclamo + ","
                        + "activo = " + iActivo + " where id_ListadoReclamos = " + iid_ListadoReclamo;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvListadoReclamos.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_ListadoReclamo = Convert.ToInt32(dgvListadoReclamos.CurrentRow.Cells["id_ListadoReclamo"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarCodCliente.Text = "";
                        txtBuscarCodCliente.Focus();

                        // retornar 
                        return;
                    }
                    // hacer lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvListadoReclamos.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_ListadoReclamos"].Value) == iid_ListadoReclamo)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvListadoReclamos.CurrentCell = dgvListadoReclamos[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvListadoReclamos_SelectionChanged(this.dgvListadoReclamos, ea);
                        }

                    }
                    // salir 
                    break;

            }
        }
        #endregion

        #region Evento click del boton  cancelar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }

        #endregion

        #region Evento click boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a M porque está haciendo una modificación
            sEstado = "M";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
        }
        #endregion

        #region Evento click boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a B porque está haciendo una búsqueda
            sEstado = "B";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
        }
        #endregion

        #region Evento click boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

        #endregion
    }
}
