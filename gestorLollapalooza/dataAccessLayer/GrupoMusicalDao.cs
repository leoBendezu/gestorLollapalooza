using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class GrupoMusicalDao
    {
        public List<GrupoMusical> RecuperarTodos()
        {
            string consulta = "SELECT * FROM grupoMusical WHERE borradoLogico = 0 ";

        

            List<GrupoMusical> grupos = new List<GrupoMusical>();


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(consulta);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                grupos.Add(this.mapearGrupoMusical(row));
            }
            return grupos;

        }

        public List<GrupoMusical> recuperarFiltrados(string filtros)
        {

            List<GrupoMusical> grupos = new List<GrupoMusical>();
            string strSql = "SELECT * " +
                            "from grupoMusical " +
                            "WHERE borradoLogico = 0 " + filtros;


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                grupos.Add(this.mapearGrupoMusical(row));
            }
            return grupos;


        }

        public bool existeGrupoMusical(GrupoMusical grupoMusical)
        {
            string strSql = "INSERT INTO [dbo].[grupoMusical] ([cantIntegrantes], [descripcion], [nombre])" +
                "VALUES ( " +
                grupoMusical.CantIntegrantes + " , '" +
                grupoMusical.Descripcion + "' , '" +
                grupoMusical.Nombre + "');";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool existeGrupoMusical(string nombreGrupoMusical)
        {

            string strSql = "SELECT * " +
                            "from grupoMusical  " +
                            "WHERE borradoLogico = 0 " +
                            " AND nombre =" + "'" + nombreGrupoMusical + "'";


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public GrupoMusical recuperarGrupo(string nombre)
        {
            // Metodo encargado de recuperar un GrupoMusical especifico de la Base de datos, recibe como parametros:
            // * String nombre de GrupoMusical
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto usuario mediante el metodo MapearGrupoMusical(), luego retorna dicho GrupoMusical.

            string strSql = "SELECT * " +
                            "from grupoMusical " +
                            "WHERE borradoLogico = 0 " +
                            " AND nombre=" + "'" + nombre + "'";


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                return this.mapearGrupoMusical(resultado.Rows[0]);
            }

            return null;
        }

        public GrupoMusical mapearGrupoMusical(DataRow row)
        {
            // Metodo encargado de convertir una fila en un objeto Usuario

            // Recuperamos los atributos del Grupo Musical de SQL a C#
            int idGrupoMusical = Convert.ToInt32(row["idGrupoMusical"].ToString());
            string GrupoNombre = row["nombre"].ToString();
            string GrupoDescripcion = row["descripcion"].ToString();
            int grupoCantIntegrantes = Convert.ToInt32(row["cantIntegrantes"].ToString());



            // Instanciamos el Grupo Musical recuperado de la BD
            GrupoMusical GrupoObj = new GrupoMusical()
            {
                IdGrupoMusical = idGrupoMusical,
                Nombre = GrupoNombre,
                Descripcion = GrupoDescripcion,
                CantIntegrantes = grupoCantIntegrantes,

            };

            return GrupoObj;
        }

        public bool borradoLogicamente(string grupoNombre)
        {
            // Metodo encargado de darle borrado logico a un grupoMusical, recibe como parametros:
            // * String nombre del grupoMusical
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE grupoMusical  SET borradoLogico = 1" +
                               "WHERE nombre = '" + grupoNombre + "'";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarGrupoMusical(GrupoMusical grupoMusical)
        {
            // Metodo encargado modificar los datos de un grupoMusical, recibe como parametros:
            // * GrupoMusical grupoMusical
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE grupoMusical  SET " +
                            "nombre = '" + grupoMusical.Nombre + "'," +
                            "descripcion = '" + grupoMusical.Descripcion + "'," +
                            "cantIntegrantes = " + grupoMusical.CantIntegrantes + "" +
                            "WHERE idGrupoMusical = " + (int)grupoMusical.IdGrupoMusical;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }


    }
}
