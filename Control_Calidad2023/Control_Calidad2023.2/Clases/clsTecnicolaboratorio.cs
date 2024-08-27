using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Calidad_2023.Clases
{
    class clsTecnicolaboratorio
    {
        public int id_TecLaboratorio { set; get; }
        public string nombreapellido { set; get; }
        public string DNI { set; get; }
        public string telefono { set; get; }
        public string gmail { set; get; }
        public int id_Laboratorio { set; get; }
        public string nomlaboratorio { set; get; }
        public bool activo { set; get; }

        public clsTecnicolaboratorio() { }

        #region Metodo que valida el nuevo formulario

        public bool cValidaTecLaboratorio()
        {
            bool aux = true;

            if (string.IsNullOrEmpty(id_Laboratorio.ToString()) || id_TecLaboratorio == 0)
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(nombreapellido.ToString()) || nombreapellido == "")
            {
                aux = false;
            }

            if (nombreapellido == "")
            {
                aux = false;
            }

            if (string.IsNullOrEmpty(DNI.ToString()) || DNI == "")
            {
                aux = false;
            }

            if (DNI == "")
            {
                aux = false;
            }

            if (telefono == "")
            {
                aux = false;
            }

            if (gmail == "")
            {
                aux = false;
            }
                       

            if (string.IsNullOrEmpty(telefono.ToString()) || telefono == "")
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
