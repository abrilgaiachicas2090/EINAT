using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad_2023.Clases
{
    class clsNombreAnalisis
    {

        public int id_NombreAnalisis { set; get; }
        public string nombreanalisis { set; get; }
        public int id_TipoAnalisis { set; get; }
        public bool activo { set; get; }

        public clsNombreAnalisis() { }

        #region Metodo que valida el nuevo formulario

        public bool cValidaNomAnalisis()
        {
            bool aux = true;

            if (string.IsNullOrEmpty(id_NombreAnalisis.ToString()) || id_NombreAnalisis == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(nombreanalisis.ToString()) || nombreanalisis == "")
            {
                aux = false;
            }

            if (nombreanalisis == "")
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
