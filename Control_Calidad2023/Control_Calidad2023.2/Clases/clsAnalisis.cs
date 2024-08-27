using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023.Clases
{
    class clsAnalisis
    {

        public int id_Analisis { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public int id_TecLaboratorio { get; set; }
        public int id_AnalisisDetalles { get; set; }
        public string nombreanalisis { get; set; }
        public int id_ResultadoAnalisis { get; set; }
        public int id_NombreAnalisis { get; set; }
        public int id_TipoAnalisis { get; set; }
        public string tipoanalisis { get; set; }
        public string TipoAgua { get; set; }
        public int id_Muestra { get; set; }
        public int id_TipoAgua { set; get; }
        public bool activo { get; set; }
        public string lugar_muestra { get; set; }
        public string cod_alimentario { get; set; }
        public string norm_provincial { get; set; }
        public string norm_provincial_limite { get; set; }
        public string cod_alimentario_limite { get; set; }
        public string nombreapellido { get; set; }
        public string resultado { get; set; }
        public int id_LugarMuestra { get; set; }
        public string lugar_aleatorio { get; set; } 

        public clsAnalisis()
        {
            id_Analisis = 0;
            fecha = DateTime.Today;
            hora = "";
            id_TecLaboratorio = 0;
            id_AnalisisDetalles = 0;
            nombreanalisis = "";
            id_ResultadoAnalisis = 0;
            id_NombreAnalisis = 0;
            id_TipoAnalisis = 0;
            tipoanalisis = "";
            TipoAgua = "";
            id_Muestra = 0;
            id_TipoAgua = 0;
            activo = false;
        }

        #region Método que valida el nuevo Parametro
        //METODO QUE VALIDA EL OBJETO LOCALIDAD (VALOR DE PROPIEDADES CARGADAS). N.
        public bool cValidaAnalisis()
        {
            //Declaro la variablede retorno
            bool aux = true;

            //Si sector está vacío
            if (string.IsNullOrEmpty(id_Analisis.ToString()) || id_NombreAnalisis == 0)
            {
                aux = false;
            }

            if (fecha == DateTime.Today)
            {
                //Cambio el estado de la variable a false
                aux = false;
            }
            if (hora == "")
            {
                //Cambio el estado de la variable a false
                aux = false;
            }

            if (string.IsNullOrEmpty(id_TecLaboratorio.ToString()) || id_TecLaboratorio == 0)
            {
                aux = false;
            }

            //if (string.IsNullOrEmpty(id_TipoAgua.ToString()) || id_TipoAgua == 0)
            //{
            //    aux = false;
            //}

           
            if (string.IsNullOrEmpty(activo.ToString()))
            {
                aux = false;
            }

            return aux;
        }
        #endregion



    }
}
