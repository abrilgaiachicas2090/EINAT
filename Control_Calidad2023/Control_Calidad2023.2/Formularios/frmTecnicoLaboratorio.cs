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
    public partial class frmTecnicoLaboratorio : Form
    {
        #region Varaible del formulario

        clsTecnicolaboratorio myTecnico = new clsTecnicolaboratorio();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";

        #endregion

        #region Constructor del formulario

        public frmTecnicoLaboratorio()
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

                    txtNombre.Enabled = true;
                    txtDNI.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;
                    cboLaboratorio.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvTecLaboratorio.Visible = true;
                    break;

                // Si está buscando
                case "B":
                    txtNombre.Enabled = false;
                    txtDNI.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;
                    cboLaboratorio.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvTecLaboratorio.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtNombre.Enabled = false;
                    txtDNI.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtGmail.Enabled = false;
                    cboLaboratorio.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvTecLaboratorio.Visible = true;
                    break;

                // Si está modificando
                case "M":
                    txtNombre.Enabled = true;
                    txtDNI.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtGmail.Enabled = true;
                    cboLaboratorio.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvTecLaboratorio.Visible = true;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarTecLaboratorio.Text = "";

        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from Vista_Teclaboratorios where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvTecLaboratorio.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvTecLaboratorio.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvTecLaboratorio.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from tecnicolaboratorios where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvTecLaboratorio.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvTecLaboratorio.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myTecnico.id_TecLaboratorio = Convert.ToInt32(dgvTecLaboratorio.CurrentRow.Cells["id_TecLaboratorio"].Value);
            myTecnico.id_Laboratorio = Convert.ToInt32(dgvTecLaboratorio.CurrentRow.Cells["id_Laboratorio"].Value);
            myTecnico.nombreapellido = Convert.ToString(dgvTecLaboratorio.CurrentRow.Cells["nombreapellido"].Value);
            myTecnico.telefono = Convert.ToString(dgvTecLaboratorio.CurrentRow.Cells["telefono"].Value);
            myTecnico.DNI = Convert.ToString(dgvTecLaboratorio.CurrentRow.Cells["DNI"].Value);
            myTecnico.gmail = Convert.ToString(dgvTecLaboratorio.CurrentRow.Cells["gmail"].Value);
        }

        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            // Cargo el combo de las provincias
            Control_Calidad2023.Clases.clsMetodos.CargarComboWhere(cboLaboratorio, "laboratorios", "nomlaboratorio", "id_Laboratorio", "Activo = 1");
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
            txtNombre.Text = myTecnico.nombreapellido;
            txtTelefono.Text = myTecnico.telefono;
            txtDNI.Text = myTecnico.DNI;
            txtGmail.Text = myTecnico.gmail;
            cboLaboratorio.SelectedValue = myTecnico.id_Laboratorio;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtNombre.Text = "";
            txtGmail.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";
            cboLaboratorio.SelectedValue = -1;
            // Ubico el foco en el primer control
            txtNombre.Focus();
        }

        #endregion

        #region Metodo de controles a objeto

        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myTecnico.nombreapellido = txtNombre.Text;
            myTecnico.DNI = txtDNI.Text;
            myTecnico.gmail = txtGmail.Text;
            myTecnico.telefono = txtTelefono.Text;
            myTecnico.id_Laboratorio = Convert.ToInt32(cboLaboratorio.SelectedValue);


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

        #region event del boton modificar

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
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Tecnico seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_TecLaboratorio = Convert.ToInt32(dgvTecLaboratorio.CurrentRow.Cells["id_TecLaboratorio"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update tecnicolaboratorios set activo = 0 where id_TecLaboratorio= " + iid_TecLaboratorio;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
        }
        #endregion

        #region eveneto del bonton buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Cambio el estado de la variable a B porque está haciendo una búsqueda
            sEstado = "B";
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //foco en la busqueda 
            txtBuscarTecLaboratorio.Focus();

        }
        #endregion

        #region evento del boton aceptar


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_TecLaboratorio = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myTecnico.cValidaTecLaboratorio() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myTecnico.nombreapellido == "")
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
                    sMycad = "insert into tecnicolaboratorios (nombreapellido, DNI, telefono,  gmail, id_Laboratorio ,activo)values("
                        + "'" + myTecnico.nombreapellido + " ', "
                        + "'" + myTecnico.DNI + " ', "
                        + "'" + myTecnico.telefono + "', "
                        + "'" + myTecnico.gmail + " ', "
                        + "'" + myTecnico.id_Laboratorio + "', "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_TecLaboratorio = Convert.ToInt32(dgvTecLaboratorio.CurrentRow.Cells["id_TecLaboratorio"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update tecnicolaboratorios  set nombreapellido = '" + myTecnico.nombreapellido + "',"
                        + "DNI = '" + myTecnico.DNI + "',"
                        + "telefono = '" + myTecnico.telefono + "',"
                        + "gmail = '" + myTecnico.gmail + "',"
                        + "activo = " + iActivo + "where id_TecLaboratorio = " + iid_TecLaboratorio;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvTecLaboratorio.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_TecLaboratorio = Convert.ToInt32(dgvTecLaboratorio.CurrentRow.Cells["id_TecLaboratorio"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarTecLaboratorio.Text = "";
                        txtBuscarTecLaboratorio.Focus();

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvTecLaboratorio.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_TecLaboratorio"].Value) == iid_TecLaboratorio)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvTecLaboratorio.CurrentCell = dgvTecLaboratorio[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvTecLaboratorio_SelectionChanged(this.dgvTecLaboratorio, ea);
                        }
                    }
                    // salir 
                    break;
            }


        }

#endregion

        #region evento TextChanged
        private void txtBuscarTecLaboratorio_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarTecLaboratorio.Text, "nombreapellido");
        }
        #endregion

        #region evento SelectionChanged
        private void dgvTecLaboratorio_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region evento del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        #region evento del boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento load

        private void frmTecnicoLaboratorio_Load(object sender, EventArgs e)
        {
            CargarFormulario();

            
        }
        #endregion

        private void dgvTecLaboratorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

       

        
        #endregion


    }
}
