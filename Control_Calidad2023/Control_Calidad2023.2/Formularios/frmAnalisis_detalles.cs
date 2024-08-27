using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad2023.Clases;

namespace Control_Calidad_2023.Formularios
{
    public partial class frmAnalisis_detalles : Form
    {
        #region Varaible del formulario
        clsAnalisisDetalles myAnalisisDetalle = new clsAnalisisDetalles();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del formulario
        public frmAnalisis_detalles()
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

                    cboResultadoAnalisis.Enabled = true;
                    cboAnalisis.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvAnalisis_detalles.Visible = true;
                    break;

                // Si está buscando
                case "B":
                    cboResultadoAnalisis.Enabled = false;
                    cboAnalisis.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvAnalisis_detalles.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    cboResultadoAnalisis.Enabled = false;
                    cboAnalisis.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvAnalisis_detalles.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    cboResultadoAnalisis.Enabled = true;
                    cboAnalisis.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvAnalisis_detalles.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarAnalisis.Text = "";
        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from vista_analisis_detalle where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvAnalisis_detalles.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvAnalisis_detalles.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvAnalisis_detalles.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from vista_analisis_detalle where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvAnalisis_detalles.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvAnalisis_detalles.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myAnalisisDetalle.id_AnalisisDetalles = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_AnalisisDetalles"].Value);
            myAnalisisDetalle.id_ResultadoAnalisis = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_ResultadoAnalisis"].Value);
            myAnalisisDetalle.id_Analisis = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_Analisis"].Value);

        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            cboResultadoAnalisis.SelectedValue = Convert.ToString(myAnalisisDetalle.id_ResultadoAnalisis);
            cboAnalisis.SelectedValue = Convert.ToString(myAnalisisDetalle.id_Analisis);

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            cboResultadoAnalisis.SelectedValue = -1;
            cboAnalisis.SelectedValue = -1;
            // Ubico el foco en el primer control
            cboResultadoAnalisis.Focus();

        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myAnalisisDetalle.id_ResultadoAnalisis = Convert.ToInt32(cboResultadoAnalisis.SelectedValue);
            myAnalisisDetalle.id_Analisis = Convert.ToInt32(cboAnalisis.SelectedValue);


        }


        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";
            // Cargo el combo de los resultados del analisis
            clsMetodos.CargarComboWhere(cboResultadoAnalisis, "resultadosanalisis", "resultado", "id_ResultadoAnalisis", "activo = 1");
            //
            clsMetodos.CargarComboWhere(cboAnalisis, "analisis1", "analisis", "id_Analisis", "activo = 1");
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //Limpiar los campos de busqueda
            LimpiarBusqueda();
            // Cargar la grilla con los datos desde la BD
            CargarGrilla();

        }

        private void cboResultadoAnalisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboResultadoAnalisis.Enabled = true;
            clsMetodos.CargarComboWhere(cboResultadoAnalisis, "resultadosanalisis", "resultado", "id_ResultadoAnalisis", "activo = 1"
                + Convert.ToInt32(cboResultadoAnalisis.SelectedValue));
        }

        #endregion

        #endregion

        #region Eventos

        #region Evento textChanged
        private void txtBuscarAnalisis_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarAnalisis.Text, "analisis");
        }
        #endregion

        #region Evento Load
        private void frmAnalisis_detalles_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region Evento selectionChanged
        private void dgvAnalisis_detalles_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Eventos de los botones

        #region Evento click boton Agregar
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

        #region Evento click boton Modificar
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

        #region evento click boton Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Nombre del detalle del analisis seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_AnalisisDetalles = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_AnalisisDetalles"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update vista_analisis_detalle set activo = 0 where id_AnalisisDetalles= " + iid_AnalisisDetalles;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
        }
        #endregion

        #region evento click boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a B porque está haciendo una búsqueda
            sEstado = "B";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //foco en la busqueda 
            txtBuscarAnalisis.Focus();
        }
        #endregion

        #region evento click boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_AnalisisDetalles = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myAnalisisDetalle.cValidaAnaDetalle() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myAnalisisDetalle.id_ResultadoAnalisis == 0)
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
                    sMycad = "insert into analisis_detalles (id_ResultadoAnalisis, id_Analisis, activo)values("
                        + "'" + myAnalisisDetalle.id_AnalisisDetalles + " ', "
                        + "'" + myAnalisisDetalle.id_Analisis + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_AnalisisDetalles = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_AnalisisDetalles"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update analisis_detalles  set id_ResultadoAnalisis = '" + myAnalisisDetalle.id_ResultadoAnalisis + "',"
                        + "id_Analisis = '" + myAnalisisDetalle.id_Analisis + "',"
                        + "activo = " + iActivo + "where id_AnalisisDetalles = " + iid_AnalisisDetalles;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvAnalisis_detalles.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_AnalisisDetalles = Convert.ToInt32(dgvAnalisis_detalles.CurrentRow.Cells["id_AnalisisDetalles"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarAnalisis.Text = "";
                        txtBuscarAnalisis.Focus();

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvAnalisis_detalles.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_AnalisisDetalles"].Value) == iid_AnalisisDetalles)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvAnalisis_detalles.CurrentCell = dgvAnalisis_detalles[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvAnalisis_detalles_SelectionChanged(this.dgvAnalisis_detalles, ea);
                        }
                    }
                    // salir 
                    break;


            }
        }

        #endregion

        #region evento click boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        private void gpbBusquedas_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
