using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class PuntoVentaDao
    {
        public IList<PuntoVenta> obtenerTodos()
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            List<PuntoVenta> puntoVentas = new List<PuntoVenta>();

            string strSql = "SELECT pv.* " +
                         "from puntoVenta pv " +
                         "WHERE pv.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                puntoVentas.Add(this.MapearPuntoVenta(row));
            }
            return puntoVentas;
        }

        public IList<PuntoVenta> recuperarFiltrados(string filtros)
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos que cumplan con ciertos filtros,
            // recibe como parametros:
            // * String filtros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            IList<PuntoVenta> puntoVentas = new List<PuntoVenta>();
            string strSql = "SELECT pv.* " +
                             "from puntoVenta pv " +
                             "WHERE pv.borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                puntoVentas.Add(this.MapearPuntoVenta(row));
            }
            return puntoVentas;
        }

        public bool persistirPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado de guardar un usuario en la base de datos, recibe como parametros:
            // Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[puntoVenta] ([nombre], [numero], [idCentroVenta])" +
                "VALUES ( ' " +
                puntoVenta.NombrePuntoVenta + "'," +
                puntoVenta.NumeroPuntoVenta + "," +
                puntoVenta.IdCentroVenta + ");";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool borradoLogicamente(string nombre)
        {
            // Metodo encargado de darle borrado logico a un usuario, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE puntoVenta  SET borradoLogico = 1" +
                               "WHERE nombre= '" + nombre + "';";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado modificar los datos de un usuario, recibe como parametros:
            // * Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE puntoVenta  SET " +
                            "nombre = '" + puntoVenta.NombrePuntoVenta + "'," +
                            "numero = '" + puntoVenta.NumeroPuntoVenta.ToString() + "'" +
                            "WHERE idPuntoVenta = " + puntoVenta.IdPuntoVenta.ToString();

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public PuntoVenta recuperarPuntoVenta(string nombre)
        {
            // Metodo encargado de recuperar un usuario especifico de la Base de datos, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto usuario mediante el metodo MapearUsuario(), luego retorna dicho usuario.
            string strSql = "SELECT pv.*" +
                             "from puntoVenta pv " +
                             "WHERE pv.borradoLogico = 0 "+
                                "AND pv.nombre like '" + nombre + "';";


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return this.MapearPuntoVenta(resultado.Rows[0]);
            }

            return null;
        }

        public PuntoVenta MapearPuntoVenta(DataRow row)
        {
            int idPuntoVenta = Convert.ToInt32(row["idPuntoVenta"].ToString());
            int numero = Convert.ToInt32(row["numero"].ToString());
            int idCentroVenta = Convert.ToInt32(row["idCentroVenta"].ToString());
            string nombre = row["nombre"].ToString();


            PuntoVenta puntoVentaObj = new PuntoVenta()
            {
                IdPuntoVenta = idPuntoVenta,
                NombrePuntoVenta = nombre,
                NumeroPuntoVenta = numero,
                IdCentroVenta = idCentroVenta
            };




            return puntoVentaObj;

        }

        public IList<PuntoVenta> obtenerTodosDeUnCentro(int idCentro)
        {

            IList<PuntoVenta> puntoVentas = new List<PuntoVenta>();

            string strSql = "SELECT pv.* " +
                         "from puntoVenta pv " +
                         "WHERE pv.borradoLogico = 0 " +
                         "AND idCentroVenta = " + idCentro;


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                puntoVentas.Add(this.MapearPuntoVenta(row));
            }
            return puntoVentas;
        }

        public IList<PuntoVenta> obtenerTodosDeUnCentroListados(int idCentro)
        {
            List<PuntoVenta> puntoVentas = new List<PuntoVenta>();

            string strSql = "SELECT pv.* " +
                         "from puntoVenta pv " +
                         "WHERE pv.borradoLogico = 0 " +
                         "AND idCentroVenta = "+ idCentro;


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                puntoVentas.Add(this.MapearPuntoVenta(row));
            }
            return puntoVentas;
        }
    }
}
