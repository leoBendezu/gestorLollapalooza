using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class TipoEntradaDao
    {
        public IList<TipoEntrada> obtenerTodos()
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            List<TipoEntrada> tipoEntradas = new List<TipoEntrada>();

            string strSql = "SELECT te.* " +
                         "from TipoEntrada te " +
                         "WHERE te.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                tipoEntradas.Add(this.MapearTipoEntrada(row));
            }
            return tipoEntradas;
        }

        public IList<TipoEntrada> recuperarFiltrados(string filtros)
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos que cumplan con ciertos filtros,
            // recibe como parametros:
            // * String filtros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            IList<TipoEntrada> tipoEntradas  = new List<TipoEntrada>();
            string strSql = "SELECT te.* " +
                             "from TipoEntrada te " +
                             "WHERE te.borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                tipoEntradas.Add(this.MapearTipoEntrada(row));
            }
            return tipoEntradas;
        }

        public bool persistirTipoEntrada(TipoEntrada tipoEntrada)
        {
            // Metodo encargado de guardar un usuario en la base de datos, recibe como parametros:
            // Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[tipoEntrada] ([descripcion], [nombre])" +
                "VALUES ( ' " +
                tipoEntrada.Descripcion + "' , '" +
                tipoEntrada.Nombre + "');";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool borradoLogicamente(string nombre)
        {
            // Metodo encargado de darle borrado logico a un usuario, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE TipoEntrada  SET borradoLogico = 1" +
                               "WHERE nombre= '" + nombre + "'";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarTipoEntrada(TipoEntrada tipoEntrada)
        {
            // Metodo encargado modificar los datos de un usuario, recibe como parametros:
            // * Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE tipoEntrada  SET " +
                            "nombre = '" + tipoEntrada.Nombre + "'," +
                            "descripcion = '" + tipoEntrada.Descripcion + "'" +
                            "WHERE idTipoEntrada = " + tipoEntrada.IdTipoEntrada.ToString();

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public TipoEntrada recuperarTipoEntrada(string nombre)
        {
            // Metodo encargado de recuperar un usuario especifico de la Base de datos, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto usuario mediante el metodo MapearUsuario(), luego retorna dicho usuario.
            string strSql = "SELECT te.* " +
                                "from TipoEntrada te " +
                                "WHERE te.borradoLogico = 0 " + 
                                "AND te.nombre like '" + nombre + "';";


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return this.MapearTipoEntrada(resultado.Rows[0]);
            }

            return null;
        }

        public TipoEntrada MapearTipoEntrada(DataRow row)
        {
            int idTipoEntrada = Convert.ToInt32(row["idTipoEntrada"].ToString());
            string nombre = row["nombre"].ToString();
            string descripcion = row["descripcion"].ToString();

            TipoEntrada tipoEntradaObj = new TipoEntrada()
            {
                IdTipoEntrada = idTipoEntrada,
                Nombre = nombre,
                Descripcion = descripcion
            };

            return tipoEntradaObj;

        }
    }
}
