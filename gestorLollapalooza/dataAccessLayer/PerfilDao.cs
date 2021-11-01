using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class PerfilDao
    {
        public IList<Perfil> obtenerTodos()
        {

            // Metodo encargado de recuperar todos los usuarios de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto perfil mediante el metodo
            // MapearPerfil(), luego retorna una lista con los perfiles.

            List<Perfil> perfiles = new List<Perfil>();

            var strSql = "SELECT p.idPerfil, p.nombrePerfil " +
                         "from perfiles p " +
                         "WHERE p.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);


            foreach (DataRow row in resultadoConsulta.Rows)
            {
                perfiles.Add(this.MapearPerfil(row));
            }
            return perfiles;
        }


        public DataTable obtenerTodosReporte()
        {



            List<Perfil> perfiles = new List<Perfil>();

            var strSql = "SELECT p.idPerfil, p.nombrePerfil " +
                         "from perfiles p " +
                         "WHERE p.borradoLogico = 0 ";


            return BDConexion.getBDConexion().EjecutarSQL(strSql);

        }

        public Perfil MapearPerfil(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto perfil

            int idPerfil = Convert.ToInt32(row["idPerfil"].ToString());
            string nombre = row["nombrePerfil"].ToString();

            Perfil perfil = new Perfil()
            {
                IdPerfil = idPerfil,
                NombrePerfil = nombre
            };

            return perfil;
        }
    }

}
