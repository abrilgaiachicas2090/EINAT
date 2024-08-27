using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad2023.Clases
{
    class clsLugarMuestra
    {
        public int id_LugarMuestra { get; set; }
        public int sector { get; set; }
        public string lugar_muestra { get; set; }
        public string lugar_aleatorio { get; set; }
        public int id_Localidad { get; set; }
        public string localidades { get; set; }
        public string observaciones { get; set; }
        public bool activo { get; set; }

        public clsLugarMuestra()
        {
            id_LugarMuestra = 0;
            sector = 0;
            lugar_muestra = "";
            lugar_aleatorio = "";
            id_Localidad = 0;
            observaciones = "";
            activo = false;
        }

        public clsLugarMuestra(int idLM, int Se, string LM, string LA, int idLo, string Ob, bool act)
        {
            id_LugarMuestra = idLM;
            sector = Se;
            lugar_muestra = LM;
            lugar_aleatorio = LA;
            id_Localidad = idLo;
            observaciones = Ob;
            activo = act;
        }

        #region Método que valida el nuevo Empleado
        //METODO QUE VALIDA EL OBJETO LOCALIDAD (VALOR DE PROPIEDADES CARGADAS). N.
        public bool cValidaLugarMuestra()
        {
            //Declaro la variablede retorno
            bool aux = false;

            //Si sector está vacío
            if (string.IsNullOrEmpty(id_LugarMuestra.ToString()) || id_LugarMuestra == 0)
            {
                aux = false;
            }

            if (sector == 0)
            {
                //Cambio el estado de la variable a false
                aux = true;
            }
            

            if (string.IsNullOrEmpty(id_Localidad.ToString()) || id_Localidad == 0)
            {
                aux = false;
            }

            if (observaciones == "")
            {
                //Cambio el estado de la variable a false
                aux = true;
            }
            if (localidades == "")
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
