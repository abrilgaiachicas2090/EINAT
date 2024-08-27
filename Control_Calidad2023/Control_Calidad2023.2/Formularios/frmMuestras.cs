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
    public partial class frmMuestras : Form
    {
        #region Varaible del formulario
        clsMuestras myMuestras = new clsMuestras();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion
        #region Constructor del formulario
        public frmMuestras()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos

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

                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    cboLugarMuestra.Enabled = true;
                    cboEmpleado.Enabled = true;
                    cboTipoAgua.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvMuestras.Visible = true;
                    break;

                // Si está buscando
                case "B":
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    cboLugarMuestra.Enabled = false;
                    cboEmpleado.Enabled = false;
                    cboTipoAgua.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvMuestras.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    cboLugarMuestra.Enabled = false;
                    cboEmpleado.Enabled = false;
                    cboTipoAgua.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvMuestras.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    cboLugarMuestra.Enabled = true;
                    cboEmpleado.Enabled = true;
                    cboTipoAgua.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvMuestras.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarLugarDeMuestra.Text = "";
        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_Muestras where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvMuestras.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvMuestras.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvMuestras.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_Muestras where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvMuestras.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvMuestras.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myMuestras.id_LugarMuestra = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_lugar_muestra"].Value);
            myMuestras.id_Empleados = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_empleado"].Value);
            myMuestras.id_TipoAgua = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_TipoAgua"].Value);
            myMuestras.fecha = Convert.ToDateTime(dgvMuestras.CurrentRow.Cells["fecha"].Value);
            myMuestras.Hora = dgvMuestras.CurrentRow.Cells["Hora"].Value.ToString();

        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            dtpFecha.Value = myMuestras.fecha;
            dtpHora.Text = myMuestras.Hora;
            cboLugarMuestra.SelectedValue = Convert.ToString(myMuestras.id_LugarMuestra);
            cboEmpleado.SelectedValue = Convert.ToString(myMuestras.id_Empleados);
            cboTipoAgua.SelectedValue = Convert.ToString(myMuestras.id_TipoAgua);
        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            dtpFecha.Text = "";
            dtpHora.Text = "";
            cboLugarMuestra.SelectedValue = -1;
            cboEmpleado.SelectedValue = -1;
            cboTipoAgua.SelectedValue = -1;
            // Ubico el foco en el primer control
            cboLugarMuestra.Focus();

        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myMuestras.fecha = dtpFecha.Value;
            myMuestras.Hora = dtpHora.Value.ToShortTimeString();
            myMuestras.id_LugarMuestra = Convert.ToInt32(cboLugarMuestra.SelectedValue);
            myMuestras.id_Empleados = Convert.ToInt32(cboEmpleado.SelectedValue);
            myMuestras.id_TipoAgua = Convert.ToInt32(cboTipoAgua.SelectedValue);


        }
        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            // Cargo el combo de las provincias
            clsMetodos.CargarComboWhere(cboLugarMuestra, "lugar_muestras", "lugar_muestra", "id_LugarMuestra", "activo = 1");
            clsMetodos.CargarComboWhere(cboEmpleado, "empleados", "nombre_apellido", "id_Empleados", "activo = 1");
            clsMetodos.CargarComboWhere(cboTipoAgua, "TiposAguas", "TipoAgua", "id_TipoAgua", "activo = 1");

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
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar los datos de la muestra seleccionada ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Muestra = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_Muestra"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update Muestras set activo = 0 where id_Muestra= " + iid_Muestra;
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
            txtBuscarLugarDeMuestra.Focus();
        }
        #endregion

        #region evento del boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_Muestra = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myMuestras.cValidaMuestra() == false)
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
                    sMycad = "insert into Muestras (id_LugarMuestra, fecha, Hora, id_Empleados, id_TipoAgua, activo)values("
                        + myMuestras.id_LugarMuestra + ", "
                        + "'" + clsMetodos.ConvertirFecha(Convert.ToDateTime(myMuestras.fecha)) + "', "
                        + "'" + myMuestras.Hora + "', "
                        + myMuestras.id_Empleados + ", "
                        + myMuestras.id_TipoAgua + ", "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Muestra = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_Muestra"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update muestras set id_LugarMuestra = '" + myMuestras.id_LugarMuestra + "',"
                        + "fecha = '"+ clsMetodos.ConvertirFecha(Convert.ToDateTime(myMuestras.fecha)) + "',"
                        + "Hora = '" + myMuestras.Hora + "',"
                         + "id_Empleados = '" + myMuestras.id_Empleados + "',"
                         + "id_TipoAgua = '" + myMuestras.id_TipoAgua + "',"
                        + "activo = " + iActivo + "where id_Muestra = " + iid_Muestra;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvMuestras.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Muestra = Convert.ToInt32(dgvMuestras.CurrentRow.Cells["id_Muestra"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtBuscarLugarDeMuestra.Text = "";
                        txtBuscarLugarDeMuestra.Focus();

                        // retornar 
                        return;

                        

                        

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvMuestras.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Muestra"].Value) == iid_Muestra)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvMuestras.CurrentCell = dgvMuestras[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvMuestras_SelectionChanged(this.dgvMuestras, ea);
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

        private void dgvMuestras_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region evento TextChanged

        private void txtBuscarLugarDeMuestra_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarLugarDeMuestra.Text, "lugar_muestra");
        }
        #endregion

        #region evento Load
        private void frmMuestras_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        private void dgvMuestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
       

        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        
    }
}

