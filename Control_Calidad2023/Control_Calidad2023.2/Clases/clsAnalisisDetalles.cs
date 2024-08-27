using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Calidad_2023.Clases;

namespace Control_Calidad2023.Clases
{
    class clsAnalisisDetalles
    {
        public int id_AnalisisDetalles { get; set; }
        public int id_ResultadoAnalisis { get; set; }
        public int id_Analisis { get; set; }
        public bool activo { get; set; }

        public clsAnalisisDetalles() { }

        #region Metodo que valida el nuevo formulario

        public bool cValidaAnaDetalle()
        {
            bool aux = true;

            if (string.IsNullOrEmpty(id_AnalisisDetalles.ToString()) || id_AnalisisDetalles == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(id_ResultadoAnalisis.ToString()) || id_ResultadoAnalisis == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(id_Analisis.ToString()) || id_Analisis == 0)
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
