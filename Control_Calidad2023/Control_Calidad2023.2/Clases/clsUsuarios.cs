using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Calidad2023;

namespace Control_Calidad2023
{
    class clsUsuarios
    {
        public int id_Usuario {set; get;}
        public string nombreapellido { set; get; }
        public string telefono { set; get; }
        public string DNI { set; get; }
        public string direccion { set; get;}
        public string gmail { set; get;}
        public string contraseña { set; get; }
        public bool activo { set; get; }


        public clsUsuarios() {}

        #region Metodo que valida el nuevo usuario

        public bool cValidaUsuario()
        {
            bool aux = true;


            if (string.IsNullOrEmpty(id_Usuario.ToString()) || id_Usuario == 0)
            {
                aux = true;
            }

            // si localidad esta vacio
            if (nombreapellido == "")
            {
                aux = false;
            }
            if (telefono == "")
            {
                aux = false;
            }
            

            if (string.IsNullOrEmpty(DNI.ToString()) || DNI == "")
            {
                aux = false;
            }
            if (string.IsNullOrEmpty(direccion.ToString()) || direccion == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(gmail.ToString()) || gmail == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(direccion.ToString()) || contraseña == "")
            {
                aux = false;
            }
           
           
            if (string.IsNullOrEmpty(activo.ToString()))
            {
                aux = false;
            }
            return aux;

        }
                #endregion
            
    }
}
