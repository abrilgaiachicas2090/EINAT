using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023.Clases
{
    class clsParametros
    {
        public int id_Parametro { get; set; }
        public string cod_alimentario { get; set; }
        public string norm_provincial { get; set; }
        public int id_NombreAnalisis { get; set; }
        public double norm_provincial_limite { get; set; }
        public double cod_alimentario_limite { get; set; }
        public bool activo { get; set; }

        public clsParametros()
        {
            id_Parametro = 0;
            cod_alimentario = "";
            norm_provincial = "";
            id_NombreAnalisis = 0;
            norm_provincial_limite = 0;
            cod_alimentario_limite = 0;
            activo = false;
        }
        public clsParametros(int idP, string ca, string np, int idna, double npl, double cal, bool act)
        {
            id_Parametro = idP;
            cod_alimentario = ca;
            norm_provincial = np;
            id_NombreAnalisis = idna;
            norm_provincial_limite = npl;
            cod_alimentario_limite = cal;
            activo = act;
        }

        #region Método que valida el nuevo Parametro
        //METODO QUE VALIDA EL OBJETO LOCALIDAD (VALOR DE PROPIEDADES CARGADAS). N.
        public bool cValidaParametro()
        {
            //Declaro la variablede retorno
            bool aux = false;

            //Si sector está vacío
            if (string.IsNullOrEmpty(id_Parametro.ToString()) || id_Parametro == 0)
            {
                aux = false;
            }

            if (cod_alimentario == "")
            {
                //Cambio el estado de la variable a false
                aux = true;
            }

            if (norm_provincial == "")
            {
                //Cambio el estado de la variable a false
                aux = true;
            }

            if (string.IsNullOrEmpty(id_NombreAnalisis.ToString()) || id_NombreAnalisis == 0)
            {
                aux = false;
            }

            if (norm_provincial_limite == 0)
            {
                //Cambio el estado de la variable a false
                aux = true;
            }

            if (cod_alimentario_limite == 0)
            {
                //Cambio el estado de la variable a false
                aux = true;
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