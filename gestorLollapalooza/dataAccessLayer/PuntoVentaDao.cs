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
        /*
        public IList<PuntoVenta> obtenerTodos()
        {
            // Metodo encargado de recuperar todos los punto de venta de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto puntoventa mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            List<PuntoVenta> usuarios = new List<PuntoVenta>();

            string strSql = "SELECT u.*, p.idPuntoVenta, p.nombre " +
                         "from PuntoVenta u JOIN CentroVenta p ON(u.idCentroVenta = p.idCentroVenta) " +
                         "WHERE u.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                usuarios.Add(this.MapearPuntoVenta(row));
            }
            return usuarios;
        }


        public Usuario recuperarPuntoVenta(string nombrePuntoVenta)
        {
            // Metodo encargado de recuperar un usuario especifico de la Base de datos, recibe como parametros:
            // * String nombrePuntoVenta
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto usuario mediante el metodo MapearUsuario(), luego retorna dicho usuario.

            string strSql = "SELECT u.*, p.idCentroVenta, p.nombre " +
                            "from PuntoVenta u JOIN centroventa p ON(u.idCentroVenta = p.idCentroVenta) " +
                            "WHERE u.borradoLogico = 0 " +
                            " AND PuntoVenta=" + "'" + nombre + "'";


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return this.MapearPuntoVenta(resultado.Rows[0]);
            }

            return null;
        }

        public bool borradoLogicamente(string nombrePuntoVenta)
        {
            // Metodo encargado de darle borrado logico a un usuario, recibe como parametros:
            // * String nombrePuntoVenta
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE PuntoVenta  SET borradoLogico = 1" +
                               "WHERE PuntVenta= '" + nombrePuntoVenta + "'";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado modificar los datos de un punto de venta, recibe como parametros:
            // *PuntoVenta puntoVenta
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE PuntoVenta  SET " +
                            "nombre = '" + puntoVenta.nombrePuntoVenta + "'," +
                            "numero = '" + puntoVenta.numeroPuntoVenta + "',";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado de guardar un usuario en la base de datos, recibe como parametros:
            // PuntoVenta puntoVenta
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[puntoVenta] ([idPuntoVenta], [nombre], [numero])" +
                "VALUES ( " +
                puntoVenta.idPuntoVenta.IdCentroVenta + " , '" +
                puntoVenta.PuntoVentaNombre + "' , '" +
                puntoVenta.PuntoVentaNumero + "' , '";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public IList<PuntoVenta> recuperarFiltrados(string filtros)
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos que cumplan con ciertos filtros,
            // recibe como parametros:
            // * String filtros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.

            IList<PuntoVenta> puntoVenta = new List<PuntoVenta>();
            string strSql = "SELECT u.*, p.idCentroVenta, p.nombre " +
                            "from puntoVenta u JOIN centroVenta p ON(u.idCentroVenta = p.idCentroVenta) " +
                            "WHERE u.borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                usuarios.Add(this.MapearPuntoVenta(row));
            }
            return puntoVenta;
        }


        public PuntoVenta MapearPuntoVenta(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto Usuario

            // Recuperamos los atributos del usuario de SQL a C#
            int idPuntoVenta = Convert.ToInt32(row["idPuntoVenta"].ToString());
            string nombrePuntoVenta = row["nombre"].ToString();
            string numero = row["numero"].ToString();


            // Recuperamos los atributos del perfil del usuario de SQL a C#

            int idCentroVenta = Convert.ToInt32(row["idCentroVenta"].ToString());
            string nombreCentroVenta = row["nombre"].ToString();


            // Instanciamos el perfil recuperado de la BD
            CentroVenta centroVenta = new CentroVenta()
            {
                IdCentroVenta = idCentroVenta,
                nombreCentroVenta = nombreCentroVenta

            };

            // Instanciamos el usuario recuperado de la BD
            PuntoVenta puntoVentaObj = new PuntoVenta()
            {
                IdPuntoVenta = idPuntoVenta,
                NombrePuntoVenta = nombrePuntoVenta

            };

            return puntoVentaObj;
        }*/
    }
}
