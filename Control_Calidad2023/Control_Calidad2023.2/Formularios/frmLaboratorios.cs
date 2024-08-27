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
    public partial class frmLaboratorios : Form
    {
        #region Varaible del formulario
        clsLaboratorio myLaboratorio = new clsLaboratorio();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del fomulario
        public frmLaboratorios()
        {
            InitializeComponent();
        }
        #endregion

        #region Evento Load
        private void frmLaboratorios_Load(object sender, EventArgs e)
        {
            CargarFormulario();
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

                    txtLaboratorio.Enabled = true;
                    txtDireccion.Enabled  = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvLaboratorio.Enabled = false;

                    break;

                // Si está buscando
                case "B":
                    txtLaboratorio.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvLaboratorio.Enabled = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtLaboratorio.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvLaboratorio.Enabled = true;
                    break;

                // Si está modificando
                case "M":
                    txtLaboratorio.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvLaboratorio.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarLaboratorio.Text = "";

        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from laboratorios where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvLaboratorio.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvLaboratorio.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvLaboratorio.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from laboratorios where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvLaboratorio.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvLaboratorio.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myLaboratorio.id_Laboratorio = Convert.ToInt32(dgvLaboratorio.CurrentRow.Cells["id_Laboratorio"].Value);
            myLaboratorio.nomlaboratorio = Convert.ToString(dgvLaboratorio.CurrentRow.Cells["nomlaboratorio"].Value);
            myLaboratorio.direccion = Convert.ToString(dgvLaboratorio.CurrentRow.Cells["direccion"].Value);
            myLaboratorio.Telefono = Convert.ToString(dgvLaboratorio.CurrentRow.Cells["telefono"].Value);
            myLaboratorio.gmail = Convert.ToString(dgvLaboratorio.CurrentRow.Cells["gmail"].Value);
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

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            txtLaboratorio.Text = myLaboratorio.nomlaboratorio;
            txtTelefono.Text = myLaboratorio.Telefono;
            txtDireccion.Text = myLaboratorio.direccion;
            txtGmail.Text = myLaboratorio.gmail;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtLaboratorio.Text = "";
            txtGmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            // Ubico el foco en el primer control
            txtLaboratorio.Focus();
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myLaboratorio.nomlaboratorio = txtLaboratorio.Text;
            myLaboratorio.direccion = txtDireccion.Text;
            myLaboratorio.gmail = txtGmail.Text;
            myLaboratorio.Telefono = txtTelefono.Text;


        }


        #endregion

        #region Eventos de los botones

        #region evento click del boton agregar
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

        #region Evento Click del boton Modificar
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

        #region evento click del boton Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Laboratorio seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Laboratorio = Convert.ToInt32(dgvLaboratorio.CurrentRow.Cells["id_Laboratorio"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update laboratorios set activo = 0 where id_Laboratorio= " + iid_Laboratorio;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
        }

        #endregion

        #region evento click del boton Buscar
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

        #region Evento click del boton Aceptar

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_Laboratorio = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myLaboratorio.cValidaLaboratorio() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myLaboratorio.nomlaboratorio == "")
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
                    sMycad = "insert into laboratorios(nomlaboratorio,Telefono, direccion, gmail ,activo)values("                        
                        + "'" + myLaboratorio.nomlaboratorio + " ', "
                        + "'" + myLaboratorio.Telefono + " ', "
                        + "'" + myLaboratorio.direccion + " ', "
                        + "'" + myLaboratorio.gmail + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Laboratorio = Convert.ToInt32(dgvLaboratorio.CurrentRow.Cells["id_Laboratorio"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update laboratorios  set nomlaboratorio = '" + myLaboratorio.nomlaboratorio + "',"
                        + "Telefono = '" + myLaboratorio.Telefono + "',"
                        + "direccion = '" + myLaboratorio.direccion + "',"
                        + "gmail = '" + myLaboratorio.gmail + "',"
                        + "activo = " + iActivo + "where id_Laboratorio = " + iid_Laboratorio;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvLaboratorio.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Laboratorio = Convert.ToInt32(dgvLaboratorio.CurrentRow.Cells["id_Laboratorio"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarLaboratorio.Text = "";
                        txtBuscarLaboratorio.Focus();
                        
                        // retornar 
                        return;
                        
                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvLaboratorio.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Laboratorio"].Value) == iid_Laboratorio)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvLaboratorio.CurrentCell = dgvLaboratorio[0, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvLaboratorio_SelectionChanged(this.dgvLaboratorio, ea);
                        }
                    }
                    // salir 
                    break;


            }
        }

        #endregion

        #region TextChanged
        private void txtBuscarLaboratorio_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarLaboratorio.Text, "nomlaboratorio");
        }
        #endregion

        #region selectionChanged
        private void dgvLaboratorio_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Evento Click del boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void gpbBusquedas_Enter(object sender, EventArgs e)
        {

        }



        #endregion




    }
}
