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
    public partial class frmParametros : Form
    {
        #region Varaible del formulario

        clsParametros myParametro = new clsParametros();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";

        #endregion

        #region Constructor del formulario

        public frmParametros()
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

                    cboNombreAnalisis.Enabled = true;
                    txtCodAlimentario.Enabled = true;
                    txtNormProvincial.Enabled = true;
                    txtLimiteCodigoAlimentario.Enabled = true;
                    txtLimiteNormProvincial.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvParametros.Enabled = false;
                    break;

                // Si está buscando
                case "B":
                    cboNombreAnalisis.Enabled = false;
                    txtCodAlimentario.Enabled = false;
                    txtNormProvincial.Enabled = false;
                    txtLimiteCodigoAlimentario.Enabled = false;
                    txtLimiteNormProvincial.Enabled = false;

                    gpbBusquedas.Visible = true;
                    dgvParametros.Enabled = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    cboNombreAnalisis.Enabled = false;
                    txtCodAlimentario.Enabled = false;
                    txtNormProvincial.Enabled = false;
                    txtLimiteCodigoAlimentario.Enabled = false;
                    txtLimiteNormProvincial.Enabled = false;

                    gpbBusquedas.Visible = false;
                    dgvParametros.Enabled = true;
                    break;

                // Si está modificando
                case "M":
                    cboNombreAnalisis.Enabled = true;
                    txtCodAlimentario.Enabled = true;
                    txtNormProvincial.Enabled = true;
                    txtLimiteCodigoAlimentario.Enabled = true;
                    txtLimiteNormProvincial.Enabled = true;

                    gpbBusquedas.Visible = false;
                    dgvParametros.Enabled = false;
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
            string sMyCad = "select * from Vista_Parametros where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvParametros.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvParametros.DataSource = myDt;
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvParametros.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region Método que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_Parametros where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvParametros.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvParametros.DataSource = myDt;
        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myParametro.id_Parametro = Convert.ToInt32(dgvParametros.CurrentRow.Cells["id_Parametro"].Value);
            myParametro.cod_alimentario = Convert.ToString(dgvParametros.CurrentRow.Cells["cod_alimentario"].Value);
            myParametro.norm_provincial = Convert.ToString(dgvParametros.CurrentRow.Cells["norm_provincial"].Value);
            myParametro.id_NombreAnalisis = Convert.ToInt32(dgvParametros.CurrentRow.Cells["id_NombreAnalisis"].Value);
            myParametro.norm_provincial_limite = Convert.ToDouble(dgvParametros.CurrentRow.Cells["norm_provincial_limite"].Value);
            myParametro.cod_alimentario_limite = Convert.ToDouble(dgvParametros.CurrentRow.Cells["cod_alimentario_limite"].Value);
        }

        #endregion

        #region Metodo que carga el formulario

        private void CargarFormulario()
        {
            // Cambio el estado de la variable a C porque no está haciendo nada
            sEstado = "C";

            //Cargar combo de la Localidad
            clsMetodos.CargarComboWhere(cboNombreAnalisis, "NombreAnalisis", "nombreanalisis", "id_NombreAnalisis", "activo = 1 ");
            // Cargar la grilla con los datos desde la BD
            CargarGrilla();
            // Ejecuto el método que muestra los botones
            ActivarBotones();
            // Ejecuto el método que habilita los controles
            HabilitarControles();
            //Limpiar los campos de busqueda
            LimpiarBusqueda();
            //limpia controles 
            LimpiarControles();
        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            cboNombreAnalisis.SelectedValue = Convert.ToString(myParametro.id_NombreAnalisis);
            txtCodAlimentario.Text = myParametro.cod_alimentario;
            txtNormProvincial.Text = myParametro.norm_provincial;
            txtLimiteNormProvincial.Text = Convert.ToString(myParametro.norm_provincial_limite);
            txtLimiteCodigoAlimentario.Text = Convert.ToString(myParametro.cod_alimentario_limite);
        }

        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            txtCodAlimentario.Text = "";
            txtNormProvincial.Text = "";
            cboNombreAnalisis.SelectedValue = -1;
            txtLimiteNormProvincial.Text = "";
            txtLimiteCodigoAlimentario.Text = "";
            // Ubico el foco en el primer control
            txtCodAlimentario.Focus();
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase
            myParametro.cod_alimentario = txtCodAlimentario.Text;
            myParametro.norm_provincial = txtNormProvincial.Text;
            myParametro.id_NombreAnalisis = Convert.ToInt32(cboNombreAnalisis.SelectedValue);
            myParametro.norm_provincial_limite = Convert.ToDouble(txtLimiteNormProvincial.Text);
            myParametro.cod_alimentario_limite = Convert.ToDouble(txtLimiteCodigoAlimentario.Text);


        }
        #endregion

        #endregion

        #region Eventos

        #region Evento click de los botones

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
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Parámetro seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Parametro = Convert.ToInt32(dgvParametros.CurrentRow.Cells["id_Parametro"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update parametros set activo = 0 where id_Parametro= " + iid_Parametro;
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
            int iid_Parametro = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myParametro.cValidaParametro() == true)
            {
                MessageBox.Show("Debe completar todos los campos", "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // controlo que la propieded marca trngan datos
            if (myParametro.cod_alimentario == "")
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
                    sMycad = "insert into parametros(id_NombreAnalisis,cod_alimentario, norm_provincial,cod_alimentario_limite, norm_provincial_limite, activo)values("
                        + "'" + myParametro.id_NombreAnalisis + " ', "
                        + "'" + myParametro.cod_alimentario + " ', "
                          + "'" + myParametro.norm_provincial + "', "
                          + myParametro.norm_provincial_limite.ToString().Replace(",", ".") + ","
                           + myParametro.cod_alimentario_limite.ToString().Replace(",", ".") + ","
                        + iActivo + ")";
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Parametro = Convert.ToInt32(dgvParametros.CurrentRow.Cells["id_Parametro"].Value);
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update parametros  set cod_alimentario = " + myParametro.cod_alimentario + ","
                        + "norm_provincial = '" + myParametro.norm_provincial + "',"
                        + "id_NombreAnalisis = '" + myParametro.id_NombreAnalisis + "',"
                        + "norm_provincial_limite = '" + myParametro.norm_provincial_limite + "',"
                        + "cod_alimentario_limite = '" + myParametro.cod_alimentario_limite + "',"
                        + "activo = " + iActivo + "where id_Parametro = " + iid_Parametro;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);
                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvParametros.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Parametro = Convert.ToInt32(dgvParametros.CurrentRow.Cells["id_Parametro"].Value);
                    }
                    else
                    {
                        // muestro un mensaje indicando que faltan datos
                        MessageBox.Show("No se encontraron coincidencias ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarAnalisis.Text = "";

                        // retornar 
                        return;

                    }
                    // haser lo mismo que el boton cancelar 
                    btnCancelar.PerformClick();
                    // recorrer la grilla para buscar el id del usuario seleccionado
                    foreach (DataGridViewRow row in dgvParametros.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Parametro"].Value) == iid_Parametro)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvParametros.CurrentCell = dgvParametros[1, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvParametros_SelectionChanged(this.dgvParametros, ea);
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

        #endregion

        #region Evento click boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
        this.Close();
        }
        #endregion

        #region Evento Selectionchanged
        private void dgvParametros_SelectionChanged(object sender, EventArgs e)
        {
            //Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();
        }
        #endregion

        #region Evento Textchanged
        private void txtBuscarCodAlimentario_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarAnalisis.Text, "nombreanalisis");
        }
#endregion

        #region Evento Load
        private void frmParametros_Load_1(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region evento enter de la busqueda

        private void txtBuscarCodAlimentario_Enter(object sender, EventArgs e)
        {
            txtBuscarAnalisis.Text = "";
        }

        #endregion

        #region Keypres Codigo Alimentario

        private void txtCodAlimentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // pongo en una variable el ascci de la tecla presionada
            char ch = e.KeyChar;

            // SI el usuario ingresa punto, lo cambio por una coma para poder hacer los cálculos
            if (ch == 46)
            {
                // Reemplazo el caracter presionado por el que necesito
                e.KeyChar = Convert.ToChar(44);
                // Lo asigno a la variable
                ch = e.KeyChar;
            }

            if (e.KeyChar == 46)
            {
                //// SI todavía no se ingresó la coma, dejo que lo ingrese
                //if (bPuntoIngresado == false)
                //{
                //    // Cambio el estado de mi bandera
                //    bPuntoIngresado = true;
                //}
                //// Pero si ya está ingresado no lo dejo
                //else
                //{
                //    // Simulo que ya se presionó la tecla, sin hacerlo
                //    e.Handled = true;
                //    // retorno a donde estaba sin hacer nada
                //    return;
                //}
            }

            // Si presiona la tecla de alguna de las operaciones matemáticas, ejecuto el código del 
            // botón correspondiente

            // SI no es un número o un caracter permitido, no hago nada
            //NUMEROS. N.
            if (!char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 13 && ch != 9)
            {
                // Simulo que ya se presionó la tecla, sin hacerlo
                e.Handled = true;
                // retorno a donde estaba sin hacer nada
                return;
            }
        }
        #endregion

        #region keypress limite codigo Alimentario

        private void txtLimiteCodigoAlimentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // pongo en una variable el ascci de la tecla presionada
            char ch = e.KeyChar;

            // SI el usuario ingresa punto, lo cambio por una coma para poder hacer los cálculos
            if (ch == 46)
            {
                // Reemplazo el caracter presionado por el que necesito
                e.KeyChar = Convert.ToChar(44);
                // Lo asigno a la variable
                ch = e.KeyChar;
            }

            if (e.KeyChar == 46)
            {
                //// SI todavía no se ingresó la coma, dejo que lo ingrese
                //if (bPuntoIngresado == false)
                //{
                //    // Cambio el estado de mi bandera
                //    bPuntoIngresado = true;
                //}
                //// Pero si ya está ingresado no lo dejo
                //else
                //{
                //    // Simulo que ya se presionó la tecla, sin hacerlo
                //    e.Handled = true;
                //    // retorno a donde estaba sin hacer nada
                //    return;
                //}
            }

            // Si presiona la tecla de alguna de las operaciones matemáticas, ejecuto el código del 
            // botón correspondiente

            // SI no es un número o un caracter permitido, no hago nada
            //NUMEROS. N.
            if (!char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 13 && ch != 9)
            {
                // Simulo que ya se presionó la tecla, sin hacerlo
                e.Handled = true;
                // retorno a donde estaba sin hacer nada
                return;
            }
        }
        #endregion

        #region Keypress Normativa provincial

        private void txtNormProvincial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // pongo en una variable el ascci de la tecla presionada
            char ch = e.KeyChar;

            // SI el usuario ingresa punto, lo cambio por una coma para poder hacer los cálculos
            if (ch == 46)
            {
                // Reemplazo el caracter presionado por el que necesito
                e.KeyChar = Convert.ToChar(44);
                // Lo asigno a la variable
                ch = e.KeyChar;
            }

            if (e.KeyChar == 46)
            {
                //// SI todavía no se ingresó la coma, dejo que lo ingrese
                //if (bPuntoIngresado == false)
                //{
                //    // Cambio el estado de mi bandera
                //    bPuntoIngresado = true;
                //}
                //// Pero si ya está ingresado no lo dejo
                //else
                //{
                //    // Simulo que ya se presionó la tecla, sin hacerlo
                //    e.Handled = true;
                //    // retorno a donde estaba sin hacer nada
                //    return;
                //}
            }

            // Si presiona la tecla de alguna de las operaciones matemáticas, ejecuto el código del 
            // botón correspondiente

            // SI no es un número o un caracter permitido, no hago nada
            //NUMEROS. N.
            if (!char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 13 && ch != 9)
            {
                // Simulo que ya se presionó la tecla, sin hacerlo
                e.Handled = true;
                // retorno a donde estaba sin hacer nada
                return;
            }
        }

        #endregion

        #region Keypress Limite Normativa Provincial
        private void txtLimiteNormProvincial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // pongo en una variable el ascci de la tecla presionada
            char ch = e.KeyChar;

            // SI el usuario ingresa punto, lo cambio por una coma para poder hacer los cálculos
            if (ch == 46)
            {
                // Reemplazo el caracter presionado por el que necesito
                e.KeyChar = Convert.ToChar(44);
                // Lo asigno a la variable
                ch = e.KeyChar;
            }

            if (e.KeyChar == 46)
            {
                //// SI todavía no se ingresó la coma, dejo que lo ingrese
                //if (bPuntoIngresado == false)
                //{
                //    // Cambio el estado de mi bandera
                //    bPuntoIngresado = true;
                //}
                //// Pero si ya está ingresado no lo dejo
                //else
                //{
                //    // Simulo que ya se presionó la tecla, sin hacerlo
                //    e.Handled = true;
                //    // retorno a donde estaba sin hacer nada
                //    return;
                //}
            }

            // Si presiona la tecla de alguna de las operaciones matemáticas, ejecuto el código del 
            // botón correspondiente

            // SI no es un número o un caracter permitido, no hago nada
            //NUMEROS. N.
            if (!char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 13 && ch != 9)
            {
                // Simulo que ya se presionó la tecla, sin hacerlo
                e.Handled = true;
                // retorno a donde estaba sin hacer nada
                return;
            }
        }
        #endregion

        private void dgvParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

    }
}
        