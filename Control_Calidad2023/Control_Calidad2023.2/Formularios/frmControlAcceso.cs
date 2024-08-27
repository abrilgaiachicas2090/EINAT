using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Calidad_2023.Clases;

namespace Control_Calidad2023.Formularios
{
    public partial class frmControlAcceso : Form
    {
        #region Variables del Formulario
        //variable que cuenta los intentos del acceso por parte del usuario
        int contarIntentos = 0;
        //variable que almacena la cantidad de intentos permitidos al usuario
        int cantIntentosPermitidos = 3;
        #endregion

        public frmControlAcceso()
        {
            InitializeComponent();
        }

        private void frmControlAcceso_Load(object sender, EventArgs e)
        {
            // cargo el combo con el nombre de los usuarios activos desde la bd
            Control_Calidad2023.Clases.clsMetodos.CargarComboWhere(CboUsuario, "usuarios", "nombreapellido", "id_Usuario", "activo = 1");
            //dejo el combo sin ningun usuario seleccionado
            CboUsuario.SelectedIndex = -1;
            //pongo el cursor en el textbox de la contraseña
            TxtContraseña.Focus();
        }

        #region evento click boton Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Evento click boton aceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //valido o controlo que se haya seleccionado un usuario y se haya
            //escrito una contraseña antes de seguir
            if (CboUsuario.SelectedIndex != -1 && TxtContraseña.Text != "")
            {
                //tomo el ID del usuario seleccionado en comboBox
                int id_Usuario = Convert.ToInt32(CboUsuario.SelectedValue);
                //armo la consulta SQL para buscar los datos del usuario en la BD 
                string SQL = "select * from usuarios where id_Usuario = "
                    + id_Usuario + " and activo = 1";
                //ejecuto la consulta y guardo el resultado en una tabla.
                DataTable dtUsuario = Control_Calidad2023.Clases.clsMetodos.GetSql(SQL);
                //Recorro la tabla para llenar el objeto 
                foreach (DataRow dt in dtUsuario.Rows)
                {
                    //paso todos los datos de la tabla al objeto
                    clsGlobales.myUsuarioPublico.id_Usuario = Convert.ToInt32(dt["id_Usuario"]);
                    clsGlobales.myUsuarioPublico.nombreapellido = dt["nombreapellido"].ToString();
                    clsGlobales.myUsuarioPublico.contraseña = dt["contraseña"].ToString();
                    clsGlobales.myUsuarioPublico.activo = Convert.ToBoolean(dt["activo"]);


                }
                // comparo si la contraseña escrita en el textbox es la misma que la que esta guardada
                if (clsGlobales.myUsuarioPublico.contraseña == TxtContraseña.Text)
                {
                    // si es igual, cierro el formulario de control de acceso de al
                    // usuario que comienze a usar el sistema.
                    this.Close();
                }
                else
                {
                    // contraseña incorrecta . muestro un mensage que lo vuelva a intentar 
                    MessageBox.Show("Contraseña incorrecta !!!. Intente nueva mente ",
                        "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtContraseña.Text = "";
                    TxtContraseña.Focus();
                    // al equibocar el usuario la contraseña, cuento los intentos 
                    contarIntentos++;
                    // preguntamos si ya iso los intentos permitidos 
                    if (contarIntentos >= cantIntentosPermitidos)
                    {
                        // mustro un mensage que el sistema se serrara por alcanzado el limite de intentos
                        MessageBox.Show("Cantidad de intentos de acceso permitidos alcanzados. el sistema se cerrara !!!.",
                            "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        // cerramos el sistema 
                        Application.Exit();
                    }
                }
            }

                // si no hay usuarios seleccionados o una contraseña escrita
                else
                {
                    // contraseña incorrecta muestro un mensage para que lo vuelva a intentar 
                    MessageBox.Show("faltan datos !!!. Intente nuevamente ", 
                        "VERIFICAR", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
        }
        #endregion
    }


    }
