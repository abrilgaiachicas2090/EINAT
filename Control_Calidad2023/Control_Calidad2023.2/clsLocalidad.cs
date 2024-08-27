using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023
{
    class clsLocalidad
    { //Propiedades de la clase
        public int id_Localidad { set; get; }
        public string localidades { set; get; }
        public bool activo { set; get; }

        //Método constructor de la clase
        public clsLocalidad() { }

        #region Métodoque valida la nueva Localidad
        //METODO QUE VALIDA EL OBJETO LOCALIDAD (VALOR DE PROPIEDADES CARGADAS). N.
        public bool cValidaLocalidades()
        {
            //Declaro la variablede retorno
            bool aux = false;

            //Si el id de la provincia es nulo o está vacío
            if (string.IsNullOrEmpty(id_Localidad.ToString()))
            {
                //Cambio el estado de la variable a false
                aux = false;

            }
            //Si Localidad está vacío
            if (localidades == "")
            {
                //Cambio el estado de la variable a false
                aux = false;
            }
           
        #endregion 
        }

    }
}