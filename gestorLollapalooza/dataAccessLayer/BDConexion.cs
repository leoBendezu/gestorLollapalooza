using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gestorLollapalooza.dataAccessLayer
{
    class BDConexion
      { 
        
        private string string_conexion;
        private static BDConexion instance = new BDConexion();


        // Probando para la transaccion
        private SqlConnection cnn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlTransaction miTransaccion = null;
        private bool estadoTransaccion = true;
        private bool Transaccion =  false;

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
            catch (SqlException ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw (ex);
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


        public object ConsultaSQLScalar(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
               // cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

        public void IniciarTransaccion()
        {
            this.Transaccion = true;
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            this.miTransaccion = cnn.BeginTransaction();
            cmd.Transaction = this.miTransaccion;
            cmd.Connection = cnn;

        }

        public void FinalizarTransaccion()
        {
            if (this.Transaccion)
            {
                if (this.estadoTransaccion)
                {

                    MessageBox.Show("PASAMOS POR COMMIT!   ", "info");
                    this.miTransaccion.Commit();
                }
                else
                {
                    MessageBox.Show("PASAMOS POR ROLLBACK!   " + this.estadoTransaccion, "info");

                    miTransaccion.Rollback();
                }
                this.Transaccion = false;
            }

            if ((cnn.State == ConnectionState.Open))
            {
                cnn.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            cnn.Dispose();
        }


        public object RecuperarIdentity(string tabla)
        {
            string strSql =" SELECT IDENT_CURRENT('" + tabla + "')";
            try
            {
                this.cmd.CommandType = CommandType.Text;
                this.cmd.CommandText = strSql ;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }

        }
        

        public int EjecutarSQLConTransaccion(string strSql)
        {
            int afectadas = 0;
            //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
            try
            {
                this.cmd.CommandType = CommandType.Text;
                this.cmd.CommandText = strSql;
                afectadas = this.cmd.ExecuteNonQuery();
                

            }
            catch
            {
                this.estadoTransaccion = false;

                MessageBox.Show("Fail" + strSql);
            }
            return afectadas;
        }

        public DataTable ConsultarTabla(string tabla)
        {
            return this.EjecutarSQL("Select * from " + tabla);
        }
    }
}
