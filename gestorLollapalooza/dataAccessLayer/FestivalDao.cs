using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gestorLollapalooza.dataAccessLayer
{
    class FestivalDao
    {
        public IList<Festival> obtenerTodos()
        {
            IList<Festival> festivales = new List<Festival>();

            string strSql = "SELECT * " +
                         "from festival " +
                         "WHERE borradoLogico = 0 ";
            

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
            string strSql = "INSERT INTO [dbo].[festival] ([añoEdicion], [descuentoVentaAnticipada], [fechaInicio], [nombre], [porcentajeDevolucionPorAnulacion], [vigente], [fechaFin])" +
                "VALUES ( " +
                festival.AnoEdicion + " , " +
                festival.DescuentoVentaAnticipada + " , '" +
                festival.FechaInicio.ToString("yyyy-MM-dd") + "' , '" +
                festival.Nombre + "' , " +
                festival.PorcentajeDevolucionPorAnulacion + " ," +
                festival.Vigente + ",'" +
                festival.FechaFin.ToString("yyyy-MM-dd") + "');";

            BDConexion.getBDConexion().IniciarTransaccion();
            BDConexion.getBDConexion().EjecutarSQLConTransaccion(strSql);

            

            var newId = BDConexion.getBDConexion().RecuperarIdentity("Festival");
            

            foreach (DiaFestival dia in festival.Dias)
            {
                strSql = "INSERT INTO [dbo].[diaFestival] ([fecha], [fechaLimiteAnulacionEntrada],[fechaVtoVentaAnticipado], [idFestival]) " +
                "VALUES ('" +
                dia.Fecha.ToString("yyyy-MM-dd") + "', '" +
                dia.FechaLimiteAnulacionEntrada.ToString("yyyy-MM-dd") + "', '" +
                dia.FechaVtoVentaAnticipada.ToString("yyyy-MM-dd") + "'," +
                newId + ");";
                BDConexion.getBDConexion().EjecutarSQLConTransaccion(strSql);


                var newIdDia = BDConexion.getBDConexion().RecuperarIdentity("diaFestival");

                foreach(Actuacion act in dia.Actuaciones)
                {
                    strSql = "INSERT INTO [dbo].[Actuacion] ([duracionEstimada], [numeroOrden],[idGrupoMusical], [idDiaFestival]) " +
                            "VALUES (" +
                            act.DuracionActuacion + "," +
                            act.NumeroOrden + "," +
                            act.GrupoMusical.IdGrupoMusical + "," +
                            newIdDia + ");";
                    BDConexion.getBDConexion().EjecutarSQLConTransaccion(strSql);

                }
               
            }

            BDConexion.getBDConexion().FinalizarTransaccion();
            return true;
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
            DateTime fechaInicio = Convert.ToDateTime(row["fechaInicio"].ToString());
            DateTime fechaFin = Convert.ToDateTime(row["fechaFin"].ToString());
            string nombre = row["nombre"].ToString();
            int porcentajeDevolucionPorAnulacion = Convert.ToInt32(row["porcentajeDevolucionPorAnulacion"].ToString());
            int vigente = Convert.ToInt32(row["vigente"]);

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
                FechaFin = fechaFin,
                Nombre = nombre,
                PorcentajeDevolucionPorAnulacion = porcentajeDevolucionPorAnulacion,
                Vigente = vigente,
                Dias = dias
            };

            return festivalObj;
        }
    }
}
