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
    public partial class frmAnalisis : Form
    {

        #region Varaible del formulario

        clsAnalisis myAnalisis = new clsAnalisis();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        string sEstado = "";
        #endregion

        #region Constructor del formulario

        public frmAnalisis()
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
                    btnBuscarMuestra.Enabled = true;
                    txtLugarMuestra.Enabled = true;
                    txtResultado.Enabled = true;
                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    cboTecLab.Enabled = true;
                    

                    gpbBusquedas.Visible = false;
                    dgvAnalisis.Enabled = false;

                    break;

                // Si está buscando
                case "B":
                    cboNombreAnalisis.Enabled = false;
                    btnBuscarMuestra.Enabled = false;
                    txtLugarMuestra.Enabled = false;
                    txtResultado.Enabled = false;
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    cboTecLab.Enabled = false;
                    

                    gpbBusquedas.Visible = true;
                    dgvAnalisis.Enabled = true;
                    break;

                // Si no está haciendo nada
                case "C":
                    cboNombreAnalisis.Enabled = false;
                    btnBuscarMuestra.Enabled = false;
                    txtLugarMuestra.Enabled = false;
                    txtResultado.Enabled = false;
                    dtpFecha.Enabled = false;
                    dtpHora.Enabled = false;
                    cboTecLab.Enabled = false;
                    

                    gpbBusquedas.Visible = false;
                    dgvAnalisis.Enabled = true;
                   
                    break;

                // Si está modificando
                case "M":
                    cboNombreAnalisis.Enabled = true;
                    btnBuscarMuestra.Enabled = true;
                    txtLugarMuestra.Enabled = true;
                    txtResultado.Enabled = true;
                    dtpFecha.Enabled = true;
                    dtpHora.Enabled = true;
                    cboTecLab.Enabled = true;
                    

                    gpbBusquedas.Visible = false;
                    dgvAnalisis.Enabled = false;
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
            string sMyCad = "select * from Vista_analisis_ultima where activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Oculto las columnas que sobran de la grilla
            dgvAnalisis.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvAnalisis.DataSource = myDt;
            
        }

        #endregion

        #region Método que deshabilita el reordenamiento de las grillas desde sus cabeceras

        private void DeshabilitarOrdenGrillas()
        {
            foreach (DataGridViewColumn dgvCol in dgvAnalisis.Columns)
            {
                dgvCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region Método que hace la busqueda

        private void BuscarRegistro(string Buscado, string Campo)
        {
            //Creo la variable y guardo la consulta SQL
            string sMyCad = "Select * from Vista_analisis_ultima where " + Campo
                + " like '%" + Buscado + "%'" + " and activo = 1";
            // Creo una tabla y ejecuto el método para cargarla
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);
            // Evito que se generen nuevas columnas de manera automática
            dgvAnalisis.AutoGenerateColumns = false;
            //paso el resultado de la consulta a la grilla
            dgvAnalisis.DataSource = myDt;
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

        }

        #endregion

        #region Método que pasa los datos de la grilla al objeto

        private void GrillaAObjeto()
        {
            // Paso los datos de la fila actual de la grilla a las propiedades de la clase
            myAnalisis.id_Analisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Analisis"].Value);
            myAnalisis.fecha = Convert.ToDateTime(dgvAnalisis.CurrentRow.Cells["fecha"].Value);
            myAnalisis.hora = dgvAnalisis.CurrentRow.Cells["hora"].Value.ToString();
            myAnalisis.id_TecLaboratorio = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_TecLaboratorio"].Value);
            myAnalisis.id_NombreAnalisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_NombreAnalisis"].Value);
            myAnalisis.id_TipoAgua = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_TipoAgua"].Value);
            myAnalisis.id_AnalisisDetalles = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_AnalisisDetalles"].Value);
            myAnalisis.id_LugarMuestra = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_LugarMuestra"].Value);
            myAnalisis.id_Muestra = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Muestra"].Value);
            myAnalisis.id_ResultadoAnalisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_ResultadoAnalisis"].Value);
            myAnalisis.id_TipoAnalisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_TipoAnalisis"].Value);
            myAnalisis.lugar_aleatorio = Convert.ToString(dgvAnalisis.CurrentRow.Cells["lugar_aleatorio"].Value);
            myAnalisis.lugar_muestra = Convert.ToString(dgvAnalisis.CurrentRow.Cells["lugar_muestra"].Value);
            myAnalisis.nombreanalisis = Convert.ToString(dgvAnalisis.CurrentRow.Cells["nombreanalisis"].Value);
            myAnalisis.nombreapellido = Convert.ToString(dgvAnalisis.CurrentRow.Cells["nombreapellido"].Value);
            myAnalisis.norm_provincial = Convert.ToString(dgvAnalisis.CurrentRow.Cells["norm_provincial"].Value);
            myAnalisis.norm_provincial_limite = Convert.ToString(dgvAnalisis.CurrentRow.Cells["norm_provincial_limite"].Value);
            myAnalisis.resultado = Convert.ToString(dgvAnalisis.CurrentRow.Cells["resultado"].Value);
            myAnalisis.TipoAgua = Convert.ToString(dgvAnalisis.CurrentRow.Cells["TipoAgua"].Value);
            myAnalisis.tipoanalisis = Convert.ToString(dgvAnalisis.CurrentRow.Cells["tipoanalisis"].Value);
            myAnalisis.cod_alimentario = Convert.ToString(dgvAnalisis.CurrentRow.Cells["cod_alimentario"].Value);
            myAnalisis.cod_alimentario_limite = Convert.ToString(dgvAnalisis.CurrentRow.Cells["cod_alimentario_limite"].Value);

        }

        #endregion

        #region Método que pasa los datos del objeto a los controles del formulario

        private void ObjetoAControles()
        {
            // Paso los datos almacenados en el objeto a los controles
            cboNombreAnalisis.SelectedValue = Convert.ToInt32(myAnalisis.id_NombreAnalisis);
            dtpFecha.Value = myAnalisis.fecha;
            dtpHora.Text = myAnalisis.hora;
            cboTecLab.SelectedValue = Convert.ToInt32(myAnalisis.id_TecLaboratorio);
            txtLugarMuestra.Text = myAnalisis.lugar_muestra;
            txtResultado.Text = myAnalisis.resultado;
        }

        #endregion

        #region Metodo de controles a objeto
        private void ControlesAObjeto()
        {
            // paso los datos de los controles al objeto de la clase
            myAnalisis.id_NombreAnalisis =Convert.ToInt32(cboNombreAnalisis.SelectedValue);
            myAnalisis.fecha = dtpFecha.Value;
            myAnalisis.hora = dtpHora.Value.ToShortTimeString();
            myAnalisis.id_TecLaboratorio = Convert.ToInt32(cboTecLab.SelectedValue);
            myAnalisis.resultado = txtResultado.Text;
            myAnalisis.lugar_muestra = txtLugarMuestra.Text;
            
        }
        #endregion

        #region Método que limpia los controles del formulario

        private void LimpiarControles()
        {
            // Limpio o vacío los controles del formulario para cargar uno nuevo
            cboNombreAnalisis.SelectedIndex = -1;
            dtpFecha.Text = "";
            dtpHora.Text = "";
            cboTecLab.SelectedIndex = -1;
            txtResultado.Text = "";
            txtLugarMuestra.Text = "";
            // Ubico el foco en el primer control
            cboNombreAnalisis.Focus();
        }

        #endregion

        #endregion

        #region Eventos

        #region Evento Load
        private void frmAnalisis_Load(object sender, EventArgs e)
        {
            //Cargar combo de la Tecnico laboratorio
            clsMetodos.CargarComboWhere(cboTecLab, "tecnicolaboratorio", "nombreapellido", "id_TecLaboratorio", "activo = 1 ");
            //Cargar combo de Tipos de agua
            clsMetodos.CargarComboWhere(cboNombreAnalisis, "NombreAnalisis", "nombreanalisis", "id_NombreAnalisis", "activo = 1");
            
            //Deshabilito el reordenamiento de la grilla
            DeshabilitarOrdenGrillas();
            
            CargarFormulario();
        }
        #endregion

        #region Evento TextChanged
        private void txtBuscarAnalisis_TextChanged(object sender, EventArgs e)
        {
            // Llamo al método que busca en tabla localidades
            // y le paso lo que el usuario escribió en el textBox de 
            // búsqueda como parámetro y en que campo de la tabla 
            // Localidades buscar
            BuscarRegistro(txtBuscarAnalisis.Text, "nombreanalisis");
        }

        //private void txtBuscarNombreAnalisis_TextChanged(object sender, EventArgs e)
        //{
        //    // Llamo al método que busca en tabla localidades
        //    // y le paso lo que el usuario escribió en el textBox de 
        //    // búsqueda como parámetro y en que campo de la tabla 
        //    // Localidades buscar
        //    BuscarRegistro(txtb, "nombreanalis");
        //}
        #endregion

        #region Evento SelectionChanged
        private void dgvAnalisis_SelectionChanged(object sender, EventArgs e)
        {
            //Paso los datos de la grilla al objeto
            GrillaAObjeto();
            // Paso los datos del objeto a los controles
            ObjetoAControles();

           
        }
        #endregion

        #region Evento Enter de busqueda
        private void gpbBusquedas_Enter(object sender, EventArgs e)
        {
            txtBuscarAnalisis.Text = "";
        }
        #endregion

        #region Evento Click botones

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

        #region Evento Click boton Modificar
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
            DialogResult myRespusta = MessageBox.Show("Desea realmente eliminar el Analisis seleccionado ?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // si la respuesta del usuario es YES o SI
            if (myRespusta == DialogResult.Yes)
            {
                // tomo el id del registro a eliminar desde la grilla 
                int iid_Analisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Analisis"].Value);
                // cambio el campo activo de la localidad borrar a false en la BD
                string sMyCadena = "update analisis1 set activo = 0 where id_Analisis= " + iid_Analisis;
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

            txtBuscarAnalisis.Focus();
        }
        #endregion

        #region Evento click boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llamo al metodo que carga el formulario
            CargarFormulario();
        }
        #endregion

        #region Evento click boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region Evento Click boton Aceptar

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // variable que va  a almacenar = 0 o 1 dependiendo del campo activo 
            int iActivo = 1;
            // variable que va a almacenar el id del usuario para la M y la B
            int iid_Analisis = 0;
            // variable donde vamos a guardar los scrips para sql
            string sMycad = "";
            // traemos los datos de los controles al objeto 
            ControlesAObjeto();
            // si los datos no estan completos, no sigo
            if (myAnalisis.cValidaAnalisis() == false)
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
                    sMycad = "insert into analisis1(fecha, hora, id_TecLaboratorio, activo)values("
                        + "'" + clsMetodos.ConvertirFecha(Convert.ToDateTime(myAnalisis.fecha)) + "', "
                          + "'" + myAnalisis.hora + " ', "
                          + myAnalisis.id_TecLaboratorio.ToString().Replace(",", ".") + ","
                        + iActivo + ")";
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    int idUltimo = 0;
                    int idUltimoAnalisis = 0;
                    int idUltimoresultadoanalisis = 0;
                    DataTable myDtp = Control_Calidad2023.Clases.clsMetodos.GetSql("select max(id_Analisis) as Id from Analisis1");
                    foreach (DataRow row in myDtp.Rows)
                    {
                        idUltimoAnalisis = Convert.ToInt32(row["Id"]);
                    }

                    // Grabar intermedia
                    sMycad = "insert into intermedia(id_Analisis, id_Muestra, activo) values (" +
                        idUltimoAnalisis + ", " +
                        clsGlobales.myMuestraPublica.id_Muestra + ",1)";
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // Grabar el valor del resultado del análisis en la tabla resultadosanalisis
                    // Buscar de esa tabla el id max (el que acabo de grabar)
                    //DataTable myDts = Control_Calidad2023.Clases.clsMetodos.GetSql("select max(id_ResultadoAnalisis) as Id from resultadosanalisis");
                    //foreach (DataRow row in myDts.Rows)
                    //{
                    //    idUltimo = Convert.ToInt32(row["Id"]);
                    //}

                    // Hacer el insert a la tabla analisis_detalles con el id_analisis y con el id_ResultadoAnalisis
                    sMycad = "insert into resultadosanalisis(resultado, activo, id_NombreAnalisis, id_Analisis) values (" +                        
                        Convert.ToDouble(txtResultado.Text) + ",1," + 
                        Convert.ToInt32(cboNombreAnalisis.SelectedValue) + ", " + idUltimoAnalisis +
                        
                        ")";
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);


                    int idUltimoAnalisisDetalle = 0;
                    DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql("select max(id_ResultadoAnalisis) as Id from resultadosanalisis");
                    foreach (DataRow row in myDt.Rows)
                    {
                        idUltimoAnalisisDetalle = Convert.ToInt32(row["Id"]);
                    }

                    // Grabar el valor del resultado del análisis en la tabla resultadosanalisis
                    // Buscar de esa tabla el id max (el que acabo de grabar)
                    sMycad = "insert into analisis_detalles( id_ResultadoAnalisis, id_Analisis, activo) values (" +
                        idUltimoAnalisisDetalle + ", " +
                        idUltimoAnalisis + ",1)";
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);



                    // llamo al metodo que carga al formulario
                    CargarFormulario();
                    // salgo del caso A
                    break;

                case "M":
                    // tomo el id del usuario a modificar de la fila actual de la grilla 
                    iid_Analisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Analisis"].Value);
                    idUltimoAnalisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_AnalisisDetalles"].Value);
                    idUltimo = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Intermedia"].Value);
                    idUltimoresultadoanalisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_ResultadoAnalisis"].Value);
                    
                   
                    // armo el escrip para actualizar la bd con los cambios realezados al registro
                    sMycad = "update analisis1  set fecha = '" + clsMetodos.ConvertirFecha(Convert.ToDateTime(myAnalisis.fecha)) + "',"
                        + "hora = '" + myAnalisis.hora + "',"
                        + "id_TecLaboratorio = " + myAnalisis.id_TecLaboratorio + ","
                        + "activo = " + iActivo + "where id_Analisis = " + iid_Analisis;
                    // ejecuto la consulta 
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    // Grabar intermedia
                    sMycad = "update intermedia set id_Analisis = " + iid_Analisis + " ,"
                        + "id_Muestra = " + myAnalisis.id_Muestra + " ,"
                        + "activo = " + iActivo + " where id_Intermedia = " + idUltimo;
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);



                    // Buscar update de analisis de detalles  (el que acabo de grabar)
                    sMycad = "update analisis_detalles set id_Analisis = " + iid_Analisis + " ,"
                        + " activo = " + iActivo + " where id_AnalisisDetalles = " + idUltimoAnalisis;
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);

                    sMycad = "update resultadosanalisis set resultado = '" + myAnalisis.resultado + "' , " 
                        + "id_NombreAnalisis = " + myAnalisis.id_NombreAnalisis + " ," 
                        + "id_Analisis = " + iid_Analisis + ","
                        + " activo = " + iActivo + " where id_ResultadoAnalisis = " + idUltimoresultadoanalisis;
                    Control_Calidad2023.Clases.clsMetodos.GetSql(sMycad);



                    // llamo el metodo que carga el formulario
                    CargarFormulario();
                    // salgo del caso m 
                    break;


                case "B":
                    if (dgvAnalisis.Rows.Count > 0)
                    {
                        // tomo el id del usuario a modificar de la fila actual de la grilla 
                        iid_Analisis = Convert.ToInt32(dgvAnalisis.CurrentRow.Cells["id_Analisis"].Value);
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
                    foreach (DataGridViewRow row in dgvAnalisis.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id_Analisis"].Value) == iid_Analisis)
                        {
                            // devuelve el foco a la fila de la grilla desde donde se llamo
                            this.dgvAnalisis.CurrentCell = dgvAnalisis[5, row.Index];

                            // ejecuto el evento selection changed de la grilla 
                            EventArgs ea = new EventArgs();
                            this.dgvAnalisis_SelectionChanged(this.dgvAnalisis, ea);
                        }
                    }
                    // salir 
                    break;
            }
        }
        #endregion

        private void btnBuscarMuestra_Click(object sender, EventArgs e)
        {
            //Abro el formulario de la búsqueda del proveedor
            frmBuscarMuestra myForm = new frmBuscarMuestra();
            myForm.ShowDialog();

            string sLugarMuestra = "";
            string sMyCad = "select * from Vista_LugarMuestra where id_LugarMuestra = " + clsGlobales.myMuestraPublica.id_LugarMuestra;
            DataTable myDt = Control_Calidad2023.Clases.clsMetodos.GetSql(sMyCad);

            foreach (DataRow row in myDt.Rows)
            {
                sLugarMuestra = row["lugar_muestra"].ToString();
            }

            //Ua vez terminada la búsqueda, paso los datos del objeto
            //público a los textBox
            //txtBuscarAnalisis.Text = Convert.ToString(clsGlobales.myAnalisisPublico.id_Analisis);
            //txtBuscarAnalisis.Text = clsGlobales.myAnalisisPublico.lugar_muestra;
            txtLugarMuestra.Text = sLugarMuestra;
        }

        

        #endregion

        private void txtLugarMuestra_TextChanged(object sender, EventArgs e)
        {

        }

       

        #endregion 

    }
}

       