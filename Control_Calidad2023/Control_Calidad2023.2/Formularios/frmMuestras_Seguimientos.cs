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

    #region Varaible del formulario
        //clsMuestrasSeguimiento myMuestraSeguimiento = new clsMuestrasSeguimiento();

        // Creo la variable que me indica que está haciendo el usuario
        // La variable va a valer "A", cuando haga un alta
        // Va a valer "B" cuando esté haciendo una búsqueda
        // Va a valer "M" cuando esté modificando
        // Va a valer "C" cuando no esté haciendo nada
        //string sEstado = "";
        #endregion

    public partial class frmMuestras_Seguimientos : Form
    {
        public frmMuestras_Seguimientos()
        {
            InitializeComponent();
        }

        private void frmMuestras_Seguimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
