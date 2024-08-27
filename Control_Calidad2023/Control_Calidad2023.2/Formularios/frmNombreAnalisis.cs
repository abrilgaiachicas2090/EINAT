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
    public partial class frmNombreAnalisis : Form
    {
        #region Varaible del formulario
        clsNombreAnalisis myNomAnalisis = new clsNombreAnalisis();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del formulario

        public frmNombreAnalisis()
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

                    txtNombreAnalisis.Enabled = true;                   
                    cboTipoAnalisis.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvNomAnalisis.Visible = true;
                    break;

                // Si está buscando
                case "B":
                    txtNombreAnalisis.Enabled = false;
                    cboTipoAnalisis.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvNomAnalisis.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtNombreAnalisis.Enabled = false;
                    cboTipoAnalisis.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvNomAnalisis.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    txtNombreAnalisis.Enabled = true;
                    cboTipoAnalisis.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvNomAnalisis.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarNAnalisis.Text = "";
        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_NomAnalisis where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvNomAnalisis.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvNomAnalisis.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvNomAnalisis.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from NombreAnalisis where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvNomAnalisis.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvNomAnalisis.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myNomAnalisis.id_NombreAnalisis = Convert.ToInt32(dgvNomAnalisis.CurrentRow.Cells["id_NombreAnalisis"].Value);
            myNomAnalisis.id_TipoAnalisis = Convert.ToInt32(dgvNomAnalisis.CurrentRow.Cells["id_TipoAnalisis"].Value);
            myNomAnalisis.nombreanalisis = Convert.ToString(dgvNomAnalisis.CurrentRow.Cells["nombreanalisis"].Value);
            
        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            txtNombreAnalisis.Text = myNomAnalisis.nombreanalisis;
            cboTipoAnalisis.SelectedValue = myNomAnalisis.id_NombreAnalisis;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtNombreAnalisis.Text = "";
            cboTipoAnalisis.SelectedValue = -1;
            // Ubico el foco en el primer control
            txtNombreAnalisis.Focus();
            
        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myNomAnalisis.nombreanalisis = txtNombreAnalisis.Text;
            myNomAnalisis.id_NombreAnalisis = Convert.ToInt32(cboTipoAnalisis.SelectedValue);


        }


        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            // Cargo el combo de las provincias
            Control_Calidad2023.Clases.clsMetodos.CargarComboWhere(cboTipoAnalisis, "tipos_analisis", "tipoanalisis", "id_TipoAnalisis", "activo = 1");
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

        #region evento del boton agregar

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

        #region evento del boton modificar

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

        #region evento del boton borrar

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Nombre del analisis seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_NomAnalisis = Convert.ToInt32(dgvNomAnalisis.CurrentRow.Cells["id_nombreanalisis"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update NombreAnalisis set activo = 0 where id_NombreAnalisis= " + iid_NomAnalisis;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
        }
        #endregion

        #region evento del boton buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a B porque está haciendo una búsqueda
            sEstado = "B";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //foco en la busqueda 
            txtBuscarNAnalisis.Focus();
        }

        #endregion

        #region evento del boton aceptar

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_NombreAnalisis = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myNomAnalisis.cValidaNomAnalisis() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myNomAnalisis.nombreanalisis == "")
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
                    sMycad = "insert into NombreAnalisis (nombreanalisis, id_TipoAnalisis ,activo)values("
                        + "'" + myNomAnalisis.nombreanalisis + " ', "
                        + "'" + myNomAnalisis.id_TipoAnalisis + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_NombreAnalisis = Convert.ToInt32(dgvNomAnalisis.CurrentRow.Cells["id_NombreAnalisis"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update NombreAnalisis  set nombreanalisis = '" + myNomAnalisis.nombreanalisis + "',"
                        + "id_TipoAnalisis = '" + myNomAnalisis.id_TipoAnalisis + "',"
                        + "activo = " + iActivo + "where id_NombreAnalisis = " + iid_NombreAnalisis;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvNomAnalisis.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_NombreAnalisis = Convert.ToInt32(dgvNomAnalisis.CurrentRow.Cells["id_NombreAnalisis"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarNAnalisis.Text = "";
                        txtBuscarNAnalisis.Focus();

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvNomAnalisis.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_NombreAnalisis"].Value) == iid_NombreAnalisis)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvNomAnalisis.CurrentCell = dgvNomAnalisis[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvNomAnalisis_SelectionChanged(this.dgvNomAnalisis, ea);
                        }
                    }
                    // salir 
                    break;


            }
        }

        #endregion

        #region evento del boton cancelar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }

        #endregion

        #region evento del boton salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region evento SelectionChanged

        private void dgvNomAnalisis_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }

        #endregion

        #region evento TextChanged

        private void txtBuscarNAnalisis_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarNAnalisis.Text, "nombreanalisis");
        }

        #endregion
        #region evento Load

        private void frmNombreAnalisis_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        #endregion

        #endregion

    }
}
