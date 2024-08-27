using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023
{
    class clsEmpleados
    { //Propiedades de la clase
        public int id_Empleados { get; set; }
        public string nombre_apellido { get; set; }
        public string telefono { get; set; }
        public string gmail { get; set; }
        public bool activo { get; set; }


         //Método constrtuctor
        public clsEmpleados()
        {
            id_Empleados = 0;
            nombre_apellido = "";
            telefono = "";
            gmail = "";
            activo = false;
        }


        //Método constructor con parametros
        public clsEmpleados(int idE, string nom_ap, string telef, string ma, bool act)
        {
            id_Empleados = idE;
            nombre_apellido = nom_ap;
            telefono = telef;
            gmail = ma;
            activo = act;
 
        }


        #region Método que valida el nuevo Empleado
        //METODO QUE VALIDA EL OBJETO LOCALIDAD (VALOR DE PROPIEDADES CARGADAS). N.
        public bool cValidaEmpleado()
        {
            //Declaro la variablede retorno
            bool aux = false;

            //Si el id del cliente es nulo o está vacío
            //if (string.IsNullOrEmpty(id_Empleados.ToString()))
            //{
            //    //Cambio el estado de la variable a false
            //    aux = false;

            //}
            //Si Nombre y Apellido está vacío
            if (nombre_apellido == "")
            {
                //Cambio el estado de la variable a false
                aux = true;
            }
            
            return aux;
        }
        #endregion
    }
}
