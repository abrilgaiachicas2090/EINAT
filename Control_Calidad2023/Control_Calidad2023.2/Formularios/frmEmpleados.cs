using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad_2023.Claseses;
using Control_Calidad2023;

namespace Control_Calidad2023.Formularios
{
    public partial class frmEmpleados : Form
    {


        #region Varaible del formulario
        clsEmpleados myEmpleado = new clsEmpleados();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del fomulario
        public frmEmpleados()
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

                    btnAgregarr.Visible = false;
                    btnModificarr.Visible = false;
                    btnEliminar.Visible = false;
                    btnBuscarr.Visible = false;
                    btnImprimirr.Visible = false;

                    btnAceptarr.Visible = true;
                    btnCancelarr.Visible = true;

                    btnSalirr.Visible = false;

                    break;

                // Si está buscando
                case "B":

                    btnAgregarr.Visible = false;
                    btnModificarr.Visible = false;
                    btnEliminar.Visible = false;
                    btnBuscarr.Visible = false;
                    btnImprimirr.Visible = false;

                    btnAceptarr.Visible = true;
                    btnCancelarr.Visible = true;

                    btnSalirr.Visible = false;

                    break;

                // Si no está haciendo nada
                case "C":

                    btnAgregarr.Visible = true;
                    btnModificarr.Visible = true;
                    btnEliminar.Visible = true;
                    btnBuscarr.Visible = true;
                    btnImprimirr.Visible = true;

                    btnAceptarr.Visible = false;
                    btnCancelarr.Visible = false;

                    btnSalirr.Visible = true;

                    break;

                // Si está modificando
                case "M":

                    btnAgregarr.Visible = false;
                    btnModificarr.Visible = false;
                    btnEliminar.Visible = false;
                    btnBuscarr.Visible = false;
                    btnImprimirr.Visible = false;

                    btnAceptarr.Visible = true;
                    btnCancelarr.Visible = true;

                    btnSalirr.Visible = false;

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

                    txtNombreyApellido.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvEmpleados.Enabled = false;
                    break;

                // Si está buscando
                case "B":
                    txtNombreyApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvEmpleados.Enabled = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtNombreyApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvEmpleados.Enabled = true;
                    break;

                // Si está modificando
                case "M":
                    txtNombreyApellido.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvEmpleados.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarNombreyApellido.Text = "";

        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from empleados where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvEmpleados.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvEmpleados.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvEmpleados.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from empleados where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvEmpleados.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvEmpleados.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myEmpleado.id_Empleados = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_Empleados"].Value);
            myEmpleado.nombre_apellido = Convert.ToString(dgvEmpleados.CurrentRow.Cells["nombre_apellido"].Value);
            myEmpleado.telefono = Convert.ToString(dgvEmpleados.CurrentRow.Cells["telefono"].Value);
            myEmpleado.gmail = Convert.ToString(dgvEmpleados.CurrentRow.Cells["gmail"].Value);
        }

        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

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
            txtNombreyApellido.Text = myEmpleado.nombre_apellido;
            txtTelefono.Text = myEmpleado.telefono;
            txtGmail.Text = myEmpleado.gmail;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtNombreyApellido.Text = "";
            txtTelefono.Text = "";
            txtGmail.Text = "";
            // Ubico el foco en el primer control
            txtNombreyApellido.Focus();
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myEmpleado.nombre_apellido = txtNombreyApellido.Text;
            myEmpleado.telefono = txtTelefono.Text;
            myEmpleado.gmail = txtGmail.Text;


        }


        #endregion
        #endregion

        #region Eventos

        #region TextChanged
        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarNombreyApellido.Text, "nombre_apellido");
        }
        #endregion

        #region selectionChanged
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Evento Load
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region Evento click del boton Agregar
        private void btnAgregarr_Click(object sender, EventArgs e)
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

        #region Evento click del boton Editar
        private void btnModificarr_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a M porque está haciendo una modificación
            sEstado = "M";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
        }
        #endregion

        #region Evento click del boton Borrar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Empleado seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Empleados = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_Empleados"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update empleados set activo = 0 where id_Empleados= " + iid_Empleados;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
        }
        #endregion

        #region Evento click del boton Buscar
        private void btnBuscarr_Click(object sender, EventArgs e)
        {
            // Cambio el estado de la variable a B porque está haciendo una búsqueda
            sEstado = "B";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
        }
        #endregion

        #region Evento click del boton Aceptar
        private void btnAceptarr_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_Empleados = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myEmpleado.cValidaEmpleado() == true)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myEmpleado.nombre_apellido == "")
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
                    sMycad = "insert into empleados(nombre_apellido,telefono, gmail ,activo)values("
                        + "'" + myEmpleado.nombre_apellido + " ', "
                        + "'" + myEmpleado.telefono + " ', "
                          + "'" + myEmpleado.gmail + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Empleados = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_Empleados"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update empleados  set nombre_apellido = '" + myEmpleado.nombre_apellido + "',"
                        + "Telefono = '" + myEmpleado.telefono + "',"
                        + "gmail = '" + myEmpleado.gmail + "',"
                        + "activo = " + iActivo + "where id_Empleados = " + iid_Empleados;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvEmpleados.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Empleados = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_Empleados"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarNombreyApellido.Text = "";
                        txtBuscarNombreyApellido.Focus();

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelarr.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvEmpleados.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Empleados"].Value) == iid_Empleados)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvEmpleados.CurrentCell = dgvEmpleados[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvEmpleados_SelectionChanged(this.dgvEmpleados, ea);
                        }
                    }
                    // salir 
                    break;
            }
        }
        #endregion

        #region Evento click del boton Cancelar
        private void btnCancelarr_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        #region Evento click del boton Salir
        private void btnSalirr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
    }
}