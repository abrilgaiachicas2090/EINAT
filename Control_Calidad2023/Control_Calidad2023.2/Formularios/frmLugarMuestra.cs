using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad2023.Clases;

namespace Control_Calidad2023.Formularios
{
    public partial class frmLugarMuestra : Form
    {
        #region Varaible del formulario
        clsLugarMuestra myLugarMuestra = new clsLugarMuestra();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del formulario
        public frmLugarMuestra()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

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

                    txtSector.Enabled = true;
                    txtLugarMuestra.Enabled = true;
                    txtLugarAleatorio.Enabled = true;
                    cboLocalidad.Enabled = true;
                    txtObservaciones.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvLugarMuestra.Enabled = false;
                    break;

                // Si está buscando
                case "B":
                    txtSector.Enabled = false;
                    txtLugarMuestra.Enabled = false;
                    txtLugarAleatorio.Enabled = false;
                    cboLocalidad.Enabled = false;
                    txtObservaciones.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvLugarMuestra.Enabled = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtSector.Enabled = false;
                    txtLugarMuestra.Enabled = false;
                    txtLugarAleatorio.Enabled = false;
                    cboLocalidad.Enabled = false;
                    txtObservaciones.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvLugarMuestra.Enabled = true;
                    break;

                // Si está modificando
                case "M":
                    txtSector.Enabled = true;
                    txtLugarMuestra.Enabled = true;
                    txtLugarAleatorio.Enabled = true;
                    cboLocalidad.Enabled = true;
                    txtObservaciones.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvLugarMuestra.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarSector.Text = "";

        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_LugarMuestra where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvLugarMuestra.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvLugarMuestra.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvLugarMuestra.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_LugarMuestra where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvLugarMuestra.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvLugarMuestra.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myLugarMuestra.id_LugarMuestra = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["id_LugarMuestra"].Value);
            myLugarMuestra.sector = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["sector"].Value);
            myLugarMuestra.lugar_muestra = Convert.ToString(dgvLugarMuestra.CurrentRow.Cells["lugar_muestra"].Value);
            myLugarMuestra.lugar_aleatorio = Convert.ToString(dgvLugarMuestra.CurrentRow.Cells["lugar_aleatorio"].Value);
            myLugarMuestra.id_Localidad = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["id_Localidad"].Value);
            myLugarMuestra.observaciones = Convert.ToString(dgvLugarMuestra.CurrentRow.Cells["observaciones"].Value);
            myLugarMuestra.localidades = Convert.ToString(dgvLugarMuestra.CurrentRow.Cells["localidades"].Value);
        }

        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            //Cargar combo de la Localidad
            clsMetodos.CargarComboWhere(cboLocalidad, "localidades", "localidades", "id_Localidad", "activo = 1 ");
            // Cargar la grilla con los datos desde la BD
            CargarGrilla();
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //Limpiar los campos de busqueda
            LimpiarBusqueda();


        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            txtSector.Text = Convert.ToString(myLugarMuestra.sector);
            txtLugarMuestra.Text = myLugarMuestra.lugar_muestra;
            txtLugarAleatorio.Text = myLugarMuestra.lugar_aleatorio;
            txtObservaciones.Text = myLugarMuestra.observaciones;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtSector.Text = "";
            txtLugarMuestra.Text = "";
            txtLugarAleatorio.Text = "";
            cboLocalidad.SelectedValue = -1;
            txtObservaciones.Text = "";
            // Ubico el foco en el primer control
            txtSector.Focus();
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myLugarMuestra.sector = Convert.ToInt32(txtSector.Text);
            myLugarMuestra.lugar_muestra = txtLugarMuestra.Text;
            myLugarMuestra.lugar_aleatorio = txtLugarAleatorio.Text;
            myLugarMuestra.id_Localidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            myLugarMuestra.observaciones = txtObservaciones.Text;


        }


        #endregion

        #endregion

        #region Eventos

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

        #region Evento Click boton Editar (Modificar)
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

        #region Evento click boton Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Lugar de la Muestra seleccionada ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_LugarMuestra = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["id_LugarMuestra"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update lugar_muestras set activo = 0 where id_LugarMuestra= " + iid_LugarMuestra;
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

        #region Evento click boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_LugarMuestra = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myLugarMuestra.cValidaLugarMuestra() == true)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // dependiendo de lo que esta haciendo el usuario
            switch (sEstado)
            {
                case "A":
                    // armo el script para hacer el insert 
                    sMycad = "insert into lugar_muestras(sector, lugar_muestra, lugar_aleatorio, id_Localidad, observaciones, activo)values("
                        + "" + myLugarMuestra.sector + " , "
                        + "'" + myLugarMuestra.lugar_muestra + " ', "
                          + "'" + myLugarMuestra.lugar_aleatorio + "', "
                          + myLugarMuestra.id_Localidad + ", "
                          + "'" + myLugarMuestra.observaciones + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_LugarMuestra = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["id_LugarMuestra"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update lugar_muestras  set sector = " + myLugarMuestra.sector + ","
                        + "lugar_muestra = '" + myLugarMuestra.lugar_muestra + "',"
                        + "lugar_aleatorio = '" + myLugarMuestra.lugar_aleatorio + "',"
                        + "id_Localidad = '" + myLugarMuestra.id_Localidad + "',"
                        + "observaciones = '" + myLugarMuestra.observaciones + "',"
                        + "activo = " + iActivo + "where id_LugarMuestra = " + iid_LugarMuestra;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvLugarMuestra.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_LugarMuestra = Convert.ToInt32(dgvLugarMuestra.CurrentRow.Cells["id_LugarMuestra"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarSector.Text = "";
                        txtBuscarSector.Focus();

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvLugarMuestra.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_LugarMuestra"].Value) == iid_LugarMuestra)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvLugarMuestra.CurrentCell = dgvLugarMuestra[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvLugarMuestra_SelectionChanged(this.dgvLugarMuestra, ea);
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

        #region Evento Selectionchanged
        private void dgvLugarMuestra_SelectionChanged(object sender, EventArgs e)
        {
           
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Evento Textchanged
        private void txtBuscarLugarMuestra_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarSector.Text, "sector");
        }
        #endregion

        #region evento Load
        private void frmLugarMuestra_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        private void dgvLugarMuestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}


