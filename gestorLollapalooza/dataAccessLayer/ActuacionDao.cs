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
    class ActuacionDao
    {
        public IList<Actuacion> obtenerTodos()
        {

            // Metodo encargado de recuperar todos los Actuacion de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto Actuacion mediante el metodo
            // MapearActuacion(), luego retorna una lista con los Actuacion.

            List<Actuacion> actuaciones = new List<Actuacion>();

            var strSql = "SELECT idActuacion, duracionEstimada, numeroOrden, idGrupoMusical, idDiaFestival " +
                         "from actuacion " +
                         "WHERE borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);


            foreach (DataRow row in resultadoConsulta.Rows)
            {
                actuaciones.Add(this.MapearActuacion(row));
            }
            return actuaciones;
        }

        public IList<Actuacion> obtenerTodosDeDiaFestival(int idDiaFestival)
        {

            List<Actuacion> actuaciones = new List<Actuacion>();

            var strSql = "SELECT idActuacion, duracionEstimada, numeroOrden, idGrupoMusical, idDiaFestival " +
                         "from actuacion " +
                         "WHERE borradoLogico = 0 " +
                         "and idDiaFestival = "+ idDiaFestival;


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);


            foreach (DataRow row in resultadoConsulta.Rows)
            {
                actuaciones.Add(this.MapearActuacion(row));
            }
            return actuaciones;
        }

        public Actuacion MapearActuacion(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto perfil

            int idActuacion = Convert.ToInt32(row["idActuacion"].ToString());
            int duracionActuacion = Convert.ToInt32(row["duracionEstimada"].ToString());
     
            int numeroOrden = Convert.ToInt32(row["numeroOrden"].ToString());
            int idGrupoMusical = Convert.ToInt32(row["idGrupoMusical"].ToString());
            int idDiaFestival = Convert.ToInt32(row["idDiaFestival"].ToString());

            GrupoMusicalService serviceG = new GrupoMusicalService();
            GrupoMusical grupo = new GrupoMusical();
            grupo = (serviceG.traerFiltrados("and idGrupoMusical = " + idGrupoMusical))[0];

            DiaFestivalService serviceD = new DiaFestivalService();
            DiaFestival dia = serviceD.recuperarDiaFestival(idDiaFestival);
            
            Actuacion actuacion = new Actuacion()
            {
                IdActuacion = idActuacion,
                DuracionActuacion = duracionActuacion,
                NumeroOrden = numeroOrden,
                GrupoMusical = grupo,

            };

            return actuacion;
        }

        public bool persistirActuacion(Actuacion actuacion)
        {
            // Metodo encargado de guardar un Actuacion en la base de datos, recibe como parametros:
            // Actuacion actuacion
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[actuacion] ([duracionActuacion], [numeroOrden], [idGrupoMusical], [idDiaFestival])" +
                "VALUES ( '" +
                actuacion.DuracionActuacion + "' , '" +
                
                actuacion.NumeroOrden + "' , '" +
                actuacion.GrupoMusical.IdGrupoMusical + "');";
            
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }
    }
}
