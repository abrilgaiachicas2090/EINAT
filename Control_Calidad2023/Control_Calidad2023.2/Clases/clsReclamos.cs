using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad_2023.Clases
{
    class clsReclamos
    {
        public int id_Reclamos { get; set; }
        public string cod_cliente { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public int id_TipoReclamo { get; set; }
        public string reclamo { get; set; }
        public bool activo { get; set; }

        public clsReclamos() { }

        public bool cValidaReclamos()
            {
            bool aux = true;

            if (string.IsNullOrEmpty(id_Reclamos.ToString()) || id_Reclamos == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(id_TipoReclamo.ToString()) || id_TipoReclamo == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(fecha.ToString()) || fecha == DateTime.Today)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(hora.ToString()) || hora == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(reclamo.ToString()) || reclamo == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(activo.ToString()))
            {
                aux = false;
            }
            return aux;
        }
    }
}
