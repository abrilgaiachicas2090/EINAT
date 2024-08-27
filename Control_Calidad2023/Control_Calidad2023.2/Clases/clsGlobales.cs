using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Control_Calidad2023.Clases;

namespace Control_Calidad2023
{
    class clsGlobales
    {
       #region Elementos de la conexion a la BD
        public static string quote = "\\";
        //Cadena de conección
        public static string SqlCadConexion = "Data Source = DESKTOP-KFR9BLR" + quote +
            "SQLEXPRESS; Initial Catalog=Control_Calidad;Integrated Security = true";
        //Creo el comando de SQL
        public static SqlCommand cmd = new SqlCommand();
        //Indicamos que conexion usaremos para el SQL
        public static SqlConnection Con = new SqlConnection(SqlCadConexion);
        #endregion 

        #region Variables públicas de la alicación
        //objeto público de la clase Usuarios
        public static clsUsuarios myUsuarioPublico = new clsUsuarios();

       
        #endregion
 

        public static clsMuestras myMuestraPublica = new clsMuestras();

        public static clsResultadoanalisis myResultadoPublico = new clsResultadoanalisis();

        public static clsAnalisisDeDetalle myAnalisisDdetallePublico = new clsAnalisisDeDetalle();

        #region Variables públicas de la aplicación
        //objeto público de la clase Usuarios
        public static clsAnalisis myAnalisisPublico = new clsAnalisis();


        #endregion
    }
    
}
