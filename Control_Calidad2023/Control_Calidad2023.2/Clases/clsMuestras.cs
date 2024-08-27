using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023.Clases
{
    class clsMuestras
    {
        public int id_Muestra { set; get; }
        public DateTime fecha { set; get; }
        public string Hora { set; get; }
        public int id_Empleados { set; get; }
        public int id_LugarMuestra { set; get; }
        public int id_TipoAgua { set; get; }
        public bool activo { set; get; }

        public clsMuestras() { }

        #region Metodo que valida el nuevo formulario

        public bool cValidaMuestra()
        {
            bool aux = true;

            if (string.IsNullOrEmpty(id_LugarMuestra.ToString()) || id_LugarMuestra == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(fecha.ToString()) || fecha == DateTime.Today)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(Hora.ToString()) || Hora == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(id_Empleados.ToString()) || id_Empleados == 0)
            {
                aux = false;
            }
            if (string.IsNullOrEmpty(id_TipoAgua.ToString()) || id_TipoAgua == 0)
            {
                aux = false;
            }

            
            return aux;

        }
        #endregion



    }


}