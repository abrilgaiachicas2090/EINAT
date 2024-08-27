﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad2023;

namespace Control_Calidad2023
{
    public partial class frm_Usuario : Form
    {
        #region Variables de el usuario
        clsUsuarios myUsuario = new clsUsuarios();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region constructor del formulario 
        public frm_Usuario()
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

                    txtNombre.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDNI.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtEmail.Enabled = true;
                    txtContraseña.Enabled = true;

                    dgvUsuario.Enabled = false;

                    gpbBusquedas.Visible = false;

                    break;

                // Si está buscando
                case "B":
                    txtNombre.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDNI.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtEmail.Enabled = false;
                    txtContraseña.Enabled = false;

                    dgvUsuario.Enabled = true;

                    gpbBusquedas.Visible = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    txtNombre.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDNI.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtEmail.Enabled = false;
                    txtContraseña.Enabled = false;

                    dgvUsuario.Enabled = true;

                    gpbBusquedas.Visible = false;
                    break;

                // Si está modificando
                case "M":
                    txtNombre.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDNI.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtEmail.Enabled = true;
                    txtContraseña.Enabled = true;

                    dgvUsuario.Enabled = false;

                    gpbBusquedas.Visible = false;
                    break;
            }
        }

        #endregion

        #region Metodo que limpia los campos de busqueda

        private void LimpiarBusqueda()
        {
            //borro el contenido de los textbox de la busqueda
            txtBuscarNombre.Text = "";

        }

        #endregion

        #region Metodo que carga los datos desde la BD

        private void CargarGrilla()
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "select * from usuarios where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvUsuario.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvUsuario.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvUsuario.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region metodo que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from usuarios where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvUsuario.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvUsuario.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myUsuario.id_Usuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["id_Usuario"].Value);
            myUsuario.nombreapellido = Convert.ToString(dgvUsuario.CurrentRow.Cells["nombreyapellido"].Value);
            myUsuario.telefono = Convert.ToString(dgvUsuario.CurrentRow.Cells["telefono"].Value);
            myUsuario.DNI = Convert.ToString(dgvUsuario.CurrentRow.Cells["DNI"].Value);
            myUsuario.direccion = Convert.ToString(dgvUsuario.CurrentRow.Cells["direccion"].Value);
            myUsuario.gmail = Convert.ToString(dgvUsuario.CurrentRow.Cells["gmail"].Value);
            myUsuario.contraseña = Convert.ToString(dgvUsuario.CurrentRow.Cells["contraseña"].Value);
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
            txtNombre.Text = myUsuario.nombreapellido;
            txtDNI.Text = myUsuario.DNI;
            txtTelefono.Text = myUsuario.telefono;
            txtDireccion.Text = myUsuario.direccion;
            txtEmail.Text = myUsuario.gmail;
            txtContraseña.Text = myUsuario.contraseña;

        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtContraseña.Text = "";
            // Ubico el foco en el primer control
            txtNombre.Focus();
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase 
            myUsuario.nombreapellido = txtNombre.Text;
            myUsuario.DNI = txtDNI.Text;
            myUsuario.gmail = txtEmail.Text;
            myUsuario.telefono = txtTelefono.Text;
            myUsuario.direccion = txtDireccion.Text;
            myUsuario.contraseña = txtContraseña.Text;


        }


        #endregion
        #endregion

        #region eventos

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

        #region evento del boton borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // pido confirmacion al usuario de la eliminacion 
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el usuario seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iidusuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["id_Usuario"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update usuarios set activo = 0 where id_Usuario= " + iidusuario;
                Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCadena);
                // cargo el formulario para que se vean los cambios 
                CargarFormulario();
            }
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

        #region evento del boton buscar
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

        #region evento del boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iidusuario = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myUsuario.cValidaUsuario() == false)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myUsuario.nombreapellido == "")
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
                    sMycad = "insert into usuarios(nombreapellido, contraseña, telefono, DNI, direccion, gmail, activo)values("
                        + "'" + myUsuario.nombreapellido + "' , "
                        + "'" + myUsuario.contraseña + "' , "
                        + "'" + myUsuario.telefono + "', "
                        + "'" + myUsuario.DNI + "', "
                        + "'" + myUsuario.direccion + "' , "
                        + "'" + myUsuario.gmail + "' , "
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iidusuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["id_Usuario"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update usuarios set nombreapellido = '" + myUsuario.nombreapellido + "'," 
                        + "telefono = '" + myUsuario.telefono + "',"
                        + "DNI = '" + myUsuario.DNI + "',"
                        + "direccion = '" + myUsuario.direccion + "',"
                        + "gmail = '" + myUsuario.gmail + "',"
                        + "contraseña = '" + myUsuario.contraseña + "',"
                        + "activo = " + iActivo + " where id_Usuario = " + iidusuario;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvUsuario.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iidusuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["id_Usuario"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarNombre.Text = "";
                        txtBuscarNombre.Focus();

                        // retornar 
                        return;

                    }
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iidusuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["id_Usuario"].Value);
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvUsuario.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Usuario"].Value) == iidusuario)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvUsuario.CurrentCell = dgvUsuario[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvUsuario_SelectionChanged(this.dgvUsuario, ea);
                        }
                    }
                    // salir 
                    break;
            }




        }
#endregion

        #region evento SelectionChanged
        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region evnto Load
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region evento busqueda
        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarNombre.Text, "nombreapellido");
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }

        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}