using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataLayer
{
    class BDConexion
    {
        private string string_conexion;
        private static BDConexion instance = new BDConexion();

        public BDConexion()
        {
            string_conexion = "Data Source=SQL5103.site4now.net;Initial Catalog=db_a79729_dynamiteteam;User Id=db_a79729_dynamiteteam_admin;Password=dt123456";
        }

        public static BDConexion getBDConexion()
        {
            if (instance == null)
                instance = new BDConexion();
            return instance;
        }

        public string obtenerConexionString()
        {
            return string_conexion;
        }


        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un valor entero con el número de filas afectadas por la sentencia ejecutada
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.



        public int ejecutarSQL(string strSql)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }


        public DataTable EjecutarSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }



        public DataTable ConsultarSQLConParametros(string sqlStr, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;


                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }

        }

        public DataTable ConsultarTabla(string tabla)
        {
            return this.EjecutarSQL("Select * from " + tabla);
        }
    }
}
