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
    class FestivalDao
    {
        public IList<Festival> obtenerTodos()
        {
            IList<Festival> festivales = new List<Festival>();

            string strSql = "SELECT * " +
                         "from festival ";/* +
                         "WHERE borradoLogico = 0 ";
            */

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);
            
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                festivales.Add(this.MapearFestival(row));
            }
            return festivales;
        }


        public bool borradoLogicamente(int idFestival)
        {
            string strSql = "UPDATE festival SET borradoLogico = 1" +
                               "WHERE idFestival = '" + idFestival + "'";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarFestival(Festival festival)
        {
            string strSql = "UPDATE festival  SET " +
                            "anoEdicion = '" + festival.AnoEdicion + "'," +
                            "descuentoVentaAnticipada = '" + festival.DescuentoVentaAnticipada + "'," +
                            "fechaInicio = '" + festival.FechaInicio + "'," +
                            "nombre = '" + festival.Nombre + "'," +
                            "porcentajeDevolucionPorAnulacion = '" + festival.PorcentajeDevolucionPorAnulacion + "'," +
                            "vigente = '" + festival.Vigente + "'" +
                            "WHERE idFestival = " + festival.IdFestival;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirFestival(Festival festival)
        {
            string strSql = "INSERT INTO [dbo].[festival] ([anoEdicion], [descuentoVentaAnticipada], [fechaInicio], [nombre], [porcentajeDevolucionPorAnulacion], [vigente])" +
                "VALUES ( " +
                festival.AnoEdicion + " , '" +
                festival.DescuentoVentaAnticipada + "' , '" +
                festival.FechaInicio + "' , '" +
                festival.Nombre + "' , '" +
                festival.PorcentajeDevolucionPorAnulacion + "' , '" +
                festival.Vigente + "');";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public IList<Festival> recuperarFiltrados(string filtros)
        {
            IList<Festival> festival = new List<Festival>();
            string strSql = "SELECT * " +
                            "from festival " +
                            "WHERE borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                festival.Add(this.MapearFestival(row));
            }
            return festival;
        }


        public Festival MapearFestival(DataRow row)
        {

            // Recuperamos los atributos del usuario de SQL a C#
            int idFestival = Convert.ToInt32(row["idFestival"].ToString());
            int anoEdicion = Convert.ToInt32(row["añoEdicion"].ToString());
            int descuentoVentaAnticipada = Convert.ToInt32(row["descuentoVentaAnticipada"].ToString());
            int fechaInicio = Convert.ToInt32(row["fechaInicio"].ToString());
            string nombre = row["nombre"].ToString();
            int porcentajeDevolucionPorAnulacion = Convert.ToInt32(row["porcentajeDevolucionPorAnulacion"].ToString());
            int vigente = Convert.ToInt32(row["vigente"].ToString());

            IList<DiaFestival> dias;
            DiaFestivalService serviceD = new DiaFestivalService();
            dias = serviceD.obtenerFiltados("and idDiaFestival = "+ idFestival);


            // Instanciamos el usuario recuperado de la BD
            Festival festivalObj = new Festival()
            {
                IdFestival = idFestival,
                AnoEdicion = anoEdicion,
                DescuentoVentaAnticipada = descuentoVentaAnticipada,
                FechaInicio = fechaInicio,
                Nombre = nombre,
                PorcentajeDevolucionPorAnulacion = porcentajeDevolucionPorAnulacion,
                Vigente = vigente,
                Dias = dias
            };

            return festivalObj;
        }
    }
}
