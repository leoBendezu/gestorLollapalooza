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
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM grupoMusical WHERE borradoLogico = 0 ";

            return BDConexion.getBDConexion().EjecutarSQL(consulta);
        }

        public DataTable recuperarFiltrados(string filtros)
        {

           DataTable gruposMusicales = new DataTable();
            string strSql = "SELECT * " +
                            "from grupoMusical " +
                            "WHERE borradoLogico = 0 " + filtros;

            return BDConexion.getBDConexion().EjecutarSQL(strSql);

        }

        public bool persistirGrupoMusical(GrupoMusical grupoMusical)
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


    }
}
