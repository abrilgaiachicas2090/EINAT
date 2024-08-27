using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad_2023.Clases
{
    class clsListado_Reclamos
    {
        public int id_ListadoReclamos { get; set; }
        public int id_Reclamos { get; set; }
        public int id_TipoReclamo { get; set; }
        public int id_EstadoReclamo { get; set; }
        public string cod_cliente { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string reclamo { get; set; }
        public string tiporeclamo { get; set; }
        public string EstadoReclamo { get; set; }
        public bool activo {get;set;}

        public clsListado_Reclamos() { }

        public bool cValidaListadoReclamos()
        {
            bool aux = true;

            if (string.IsNullOrEmpty(id_EstadoReclamo.ToString()) || id_EstadoReclamo == 0)
            {
                aux = false;
            }
           
            return aux;

        }

        
    }
}