using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad_2023.Clases;

namespace Control_Calidad_2023.form
{
    public partial class frmReclamos : Form
    {

        #region Varaible del formulario
        clsReclamos myReclamo = new clsReclamos();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region constructor del formulario
        public frmReclamos()
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

                    btnAgregar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnBuscar.Visible = false;
                    btnImprimir.Visible = false;

                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    btnSalir.Visible = false;

                    break;

                // Si está buscando
                case "B":

                    btnAgregar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnBuscar.Visible = false;
                    btnImprimir.Visible = false;

                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    btnSalir.Visible = false;

                    break;

                // Si no está haciendo nada
                case "C":

                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnBorrar.Visible = true;
                    btnBuscar.Visible = true;
                    btnImprimir.Visible = true;

                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;

                    btnSalir.Visible = true;

                    break;

                // Si está modificando
                case "M":

                    btnAgregar.Visible = false;
                    btnModificar.Visible = false;
                    btnBorrar.Visible = false;
                    btnBuscar.Visible = false;
                    btnImprimir.Visible = false;

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
                // Si está haciendo un alta
                case "A":

                    txtReclamo.Enabled = true;
                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    txtCodCliente.Enabled = true;
                    cboTipoReclamo.Enabled = true;


                    gpbBusquedas.Visible = false;
                    dgvReclamos.Visible = true;
                    break;

                // Si está buscando
                case "B":
                    txtReclamo.Enabled = false;
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    txtCodCliente.Enabled = false;
                    cboTipoReclamo.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvReclamos.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtReclamo.Enabled = false;
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    txtCodCliente.Enabled = false;
                    cboTipoReclamo.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvReclamos.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    txtReclamo.Enabled = true;
                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    txtCodCliente.Enabled = true;
                    cboTipoReclamo.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvReclamos.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarCodCliente.Text = "";
        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_Reclamos where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvReclamos.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvReclamos.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvReclamos.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_Reclamos where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvReclamos.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvReclamos.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myReclamo.cod_cliente = Convert.ToString(dgvReclamos.CurrentRow.Cells["cod_cliente"].Value);
            myReclamo.fecha = Convert.ToDateTime(dgvReclamos.CurrentRow.Cells["fecha"].Value);
            myReclamo.hora = dgvReclamos.CurrentRow.Cells["hora"].Value.ToString();
            myReclamo.reclamo = Convert.ToString(dgvReclamos.CurrentRow.Cells["reclamo"].Value);
            myReclamo.id_TipoReclamo = Convert.ToInt32(dgvReclamos.CurrentRow.Cells["id_TipoReclamo"].Value);

        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
             txtReclamo.Text = myReclamo.reclamo;
             dtpFecha.Value = myReclamo.fecha;
            dtpHora.Value = Convert.ToDateTime(myReclamo.hora);
            cboTipoReclamo.SelectedValue = Convert.ToString(myReclamo.id_TipoReclamo);
            txtCodCliente.Text = myReclamo.cod_cliente;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
             // Limpio o vacío los controles del formulario para cargar uno nuevo
            dtpFecha.Text = "";
            dtpHora.Text = "";
            cboTipoReclamo.SelectedValue = -1;
            txtReclamo.Text = "";
            txtCodCliente.Text = "";
            // Ubico el foco en el primer control
            cboTipoReclamo.Focus();

        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
           // paso los datos de los controles al objeto de la clase 
            myReclamo.fecha = dtpFecha.Value;
            myReclamo.hora = dtpHora.Value.ToShortTimeString();
            myReclamo.id_TipoReclamo = Convert.ToInt32(cboTipoReclamo.SelectedValue);
            myReclamo.reclamo = txtReclamo.Text;
            myReclamo.cod_cliente = txtCodCliente.Text;


        }


        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            // Cargo el combo de los resultados del analisis
            Control_Calidad2023.Clases.clsMetodos.CargarComboWhere(cboTipoReclamo, "tipos_reclamo", "tiporeclamo", "id_TipoReclamo", "activo = 1");
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

        #region Eventos

        #region Evento LOAD
        private void frmReclamos_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region Evento TextChanged cod Cliente
        private void txtBuscarCodCliente_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarCodCliente.Text, "cod_cliente");
        }
        #endregion

        //#region Evento TextChanged
        //private void frmReclamos_TextChanged(object sender, EventArgs e)
        //{
        //    CargarFormulario();
        //}

        #region Evento SelectionChanged
        private void dgvReclamos_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Eventos de los botones

        #region Evento click boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_Reclamos = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myReclamo.cValidaReclamos() == true)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myReclamo.reclamo == "")
            {
                // muestro un mensaje indicando que faltan datos
                MessageBox.Show("Debe completar todos los datos !!! ", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // retornar 
                return;
            }
            // dependiendo de lo que esta haciendo el usuario
            switch (sEstado)
            {
                case "A":
                    // armo el script para hacer el insert 
                    sMycad = "insert into reclamos(cod_cliente, fecha, hora, reclamo, id_TipoReclamo, activo)values("
                        + "'" + myReclamo.cod_cliente + " ', "
                        + "'" + Control_Calidad2023.Clases.clsMetodos.ConvertirFecha(Convert.ToDateTime(myReclamo.fecha)) + "', "
                        + "'" + myReclamo.hora + " ', "
                        + "'" + myReclamo.reclamo + "', "
                        + myReclamo.id_TipoReclamo + ", "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    int idRecl = 0;
                    sMycad = "select Max(id_Reclamos) as Ultimo from reclamos";
                    DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    foreach (DataRow row in myDt.Rows)
                    {
                        idRecl = Convert.ToInt32(row["Ultimo"]);
                    }

                    sMycad = "insert into Listado_Reclamos(id_Reclamos, id_EstadoReclamo, activo) values (" +
                        idRecl + ", " +
                        myReclamo.id_TipoReclamo + ",1)";
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);


                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Reclamos = Convert.ToInt32(dgvReclamos.CurrentRow.Cells["id_Reclamo"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update reclamos  set cod_cliente = '" + myReclamo.cod_cliente + "',"
                        + "fecha = '" + Control_Calidad2023.Clases.clsMetodos.ConvertirFecha(Convert.ToDateTime(myReclamo.fecha)) + "',"
                        + "hora = '" + myReclamo.hora + "',"
                        + "reclamo = '" + myReclamo.reclamo + "',"
                        + "id_TipoReclamo = '" + myReclamo.id_TipoReclamo + "',"
                        + "activo = " + iActivo + "where id_Reclamos = " + iid_Reclamos;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvReclamos.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Reclamos = Convert.ToInt32(dgvReclamos.CurrentRow.Cells["id_Reclamos"].Value);
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
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvReclamos.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Reclamos"].Value) == iid_Reclamos)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvReclamos.CurrentCell = dgvReclamos[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvReclamos_SelectionChanged(this.dgvReclamos, ea);
                        }

                    }
                    // salir 
                    break;

            }
        }
        #endregion

        #region Evento click boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        #region Evento Click boton Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a A porque está haciendo un alta
            sEstado = "A";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            // Limpio los controles del formulario para cargar los nuevos datos
            LimpiarControles();
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

        #region Evento click boton borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Reclamo seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Reclamo = Convert.ToInt32(dgvReclamos.CurrentRow.Cells["id_Reclamos"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update reclamos set activo = 0 where id_Reclamos= " + iid_Reclamo;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
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
