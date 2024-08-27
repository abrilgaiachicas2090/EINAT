using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_Calidad2023.Clases
{
    class clsMetodos
    {
        #region Metodo para cargar la consulta SQL en DataAdapter
        public static DataTable GetSql(string mySql)
        {
            //DataTable para retorno
            DataTable myDataTable = new DataTable();
            //Abro la conexion a la base de datos
            clsGlobales.Con.Open();
            //Declaro el comando y le paso los parámetros
            SqlCommand cmd = new SqlCommand(mySql, clsGlobales.Con);
            //Declaro el adaptador y los instancio 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Paso los datos de la consulta al DataAdapter
            adapter.Fill(myDataTable);
            //Cierro la conexion
            clsGlobales.Con.Close();
            //Retornar DataTable
            return myDataTable;
        }
        #endregion

        #region Metodo que carga los combos 
        public static void CargarCombo(ComboBox nombreCombo, string TablaOrigenDatos,
            string CampoAMostrar, string idTabla)
        {
            //Creo la tabla
            DataTable myDataTable = new DataTable();
            //Llamo al metodo que lee la base de todos y cargo las filas a la tabla
            myDataTable = GetSql("SELECT * FROM " + TablaOrigenDatos + " ORDER BY "
                + CampoAMostrar);
            //Asigno los valores recibidos de la consulta al combo
            //Nobre de la columna a mostrar
            nombreCombo.DisplayMember = CampoAMostrar;
            //Clave primaria de la tabla (id)
            nombreCombo.ValueMember = idTabla;
            //Devuelve una tabla y se la asigna al combo
            nombreCombo.DataSource = myDataTable;
        }
        #endregion

        #region Método que carga los combos
        public static void CargarComboWhere(ComboBox nombreCombo, string TablaOrigenDatos, string CampoAMostrar,
        string IdTabla, string sWhere)
        {
            //creo la tabla
            DataTable myDataTable = new DataTable();
            //Llamo al método que lee la base de datos y cargo las fias a la tabla
            myDataTable = GetSql("SELECT * FROM " + TablaOrigenDatos + " where " + sWhere + " ORDER BY " + CampoAMostrar);
            //Asigno los valores recibidos de la consulta al combo
            nombreCombo.DisplayMember = CampoAMostrar;
            nombreCombo.ValueMember = IdTabla;
            nombreCombo.DataSource = myDataTable;
        }
        #endregion 

        #region Método que modifica la fecha
        //Invierte dia y mes (los acomoda de distinta forma)
        public static string ConvertirFecha(DateTime FechaOrigen)
        {
        string Retorno = "";
        int iDia = FechaOrigen.Day;
        int iMes = FechaOrigen.Month;
        int iAño = FechaOrigen.Year;
        
        Retorno = iMes.ToString() + "/" + iDia.ToString() + "/" + iAño.ToString();

        return Retorno;
        }
#endregion





    }
}
    