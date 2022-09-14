using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace inventarioapi.utiles
{
    public class ssql
    {
        public static DataTable runSelect(string SQL)
        {
            try
            {
                string conexiondbstring = ConfigurationManager.AppSettings["conexiondbstring"];
                SqlConnection conn = new SqlConnection(conexiondbstring);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL;
                da.SelectCommand = cmd;
                DataTable ds = new DataTable();
                ///conn.Open();
                da.Fill(ds);
                ///conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                DataTable ds = new DataTable();
                return ds;
            }
        }
    }
}