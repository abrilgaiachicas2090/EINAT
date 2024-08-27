using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad_2023.Claseses
{
    class clsLaboratorio
    {
        public int id_Laboratorio { set; get; }
        public string nomlaboratorio { set; get; }
        public string direccion { set; get; }
        public string Telefono { set; get; }
        public string gmail { set; get; }
        public bool activo { set; get; }

        public clsLaboratorio() { }


        #region Metodo que valida el nuevo laboratorio
        public bool cValidaLaboratorio()
        {
            bool aux = true;


            if (string.IsNullOrEmpty(id_Laboratorio.ToString()) || id_Laboratorio == 0)
            {
                aux = false;
            }

            // si laboratorio esta vacio
            if (nomlaboratorio == "")
            {
                aux = false;
            }
            if (direccion == "")
            {
                aux = false;
            }
            ;
            if (Telefono == "")
            {
                aux = false;
            }
            if (gmail == "")
            {
                aux = false;
            }
            

            if (string.IsNullOrEmpty(Telefono.ToString()) || Telefono == "")
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


            if (string.IsNullOrEmpty(activo.ToString()))
            {
                aux = false;
            }
            return aux;

        }
        #endregion

        
    }
}
