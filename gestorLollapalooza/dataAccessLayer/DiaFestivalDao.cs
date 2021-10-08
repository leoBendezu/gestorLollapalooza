using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class DiaFestivalDao
    {
        public IList<DiaFestival> obtenerTodos()
        {
            // Metodo encargado de recuperar todos los DiaFestival de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearDiaFestival(), luego retorna una lista con los DiaFestival.

            List<DiaFestival> diasFestival = new List<DiaFestival>();

            string strSql = "SELECT * " +
                         "from diaFestival  " +
                         "WHERE borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                diasFestival.Add(this.MapearDiaFestival(row));
            }
            return diasFestival;
        }

        public DiaFestival MapearDiaFestival(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto DiaFestival

            // Recuperamos los atributos del usuario de SQL a C#
            int idDiaFestival = Convert.ToInt32(row["idDiaFestival"].ToString());
            int fecha = (int)row["fecha"];
            int fechaLimiteAnulacionEntrada = (int)row["fechaLimiteAnulacionEntrada"];
            int fechaVtoVentaAnticipada = (int)row["fechaVtoAnticipada"];
            int horaPresentacion = (int)row["horaPresentacion"];

            // Recuperamos los atributos del Festival del DiaFestival de SQL a C#

            int idFestival = Convert.ToInt32(row["idFestival"].ToString());

            ActuacionService serviceA = new ActuacionService();
            IList<Actuacion> actuaciones = serviceA.obtenerTodosDeDiaFestival(idDiaFestival);

            // Instanciamos el DiaFestival recuperado de la BD
            DiaFestival diaFestivalObj = new DiaFestival()
            {
                IdDiaFestival = idDiaFestival,
                Fecha = fecha,
                FechaLimiteAnulacionEntrada = fechaLimiteAnulacionEntrada,
                FechaVtoVentaAnticipada = fechaVtoVentaAnticipada,
                HoraPresentacion = horaPresentacion,
                IdFestival = idFestival,
                Actuaciones = actuaciones
            };

            return diaFestivalObj;
        }


        public DiaFestival recuperarDiaFestival(int idDiaFestival)
        {
            // Metodo encargado de recuperar un DiaFestival especifico de la Base de datos, recibe como parametros:
            // * int idDiaFestival
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto DiaFestival mediante el metodo MapearDiaFestival(), luego retorna dicho DiaFestival.

            string strSql = "SELECT * " +
                            "from diaFestival " +
                            "WHERE borradoLogico = 0 " +
                            " AND idDiaFestival =" + idDiaFestival ;


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return this.MapearDiaFestival(resultado.Rows[0]);
            }

            return null;
        }

        public bool borradoLogicamente(int idDiaFestival)
        {
            // Metodo encargado de darle borrado logico a un usuario, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE diaFestival  SET borradoLogico = 1" +
                               "WHERE idDiaFestival = " + idDiaFestival ;
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarDiaFestival(DiaFestival diaFestival)
        {
            // Metodo encargado modificar los datos de un DiaFestival, recibe como parametros:
            // * DiaFestival diaFestival
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE diaFestival  SET " +
                            "fecha = '" + diaFestival.Fecha + "'," +
                            "fechaLimiteAnulacionEntrada = '" + diaFestival.FechaLimiteAnulacionEntrada + "'," +
                            "fechaVtoVentaAnticipada = '" + diaFestival.FechaVtoVentaAnticipada + "'," +
                            "horaPresentacion = '" + diaFestival.HoraPresentacion + "'" +
                            "WHERE idDiaFestival = " + diaFestival.IdDiaFestival;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirDiaFestival(DiaFestival diaFestival)
        {
            // Metodo encargado de guardar un DiaFestival en la base de datos, recibe como parametros:
            // * DiaFestival diaFestival
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[diaFestival] ([fecha], [fechaLimiteAnulacionEntrada], [fechaVtoVentaAnticipada]," +
                " [horaPresentacion], [idFestival])" +
                "VALUES ( '" +
                diaFestival.Fecha + "' , '" +
                diaFestival.FechaLimiteAnulacionEntrada + "' , '" +
                diaFestival.FechaVtoVentaAnticipada + "' , " +
                diaFestival.HoraPresentacion + " , " +
                diaFestival.IdFestival + ");";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public IList<DiaFestival> recuperarFiltrados(string filtros)
        {
            // Metodo encargado de recuperar todos los DiaFestival de la Base de datos que cumplan con ciertos filtros,
            // recibe como parametros:
            // * String filtros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearDiaFestival(), luego retorna una lista con los DiaFestival.

            IList<DiaFestival> diasFestival = new List<DiaFestival>();
            string strSql = "SELECT * " +
                            "from diaFEstival " +
                            "WHERE borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                diasFestival.Add(this.MapearDiaFestival(row));
            }
            return diasFestival;
        }



    }
}
