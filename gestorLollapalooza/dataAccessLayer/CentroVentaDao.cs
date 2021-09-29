﻿using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class CentroVentaDao
    {
        public DataTable obtenerTodos()
        {
        

            string strSql = "SELECT * " +
                         "from centroVenta  " +
                         "WHERE borradoLogico = 0 ";


            return BDConexion.getBDConexion().EjecutarSQL(strSql);
        }


        public CentroVenta recuperarCentroVenta(string nombreCentroVenta)
        {

            string strSql = "SELECT * " +
                            "from centroVenta " +
                            "WHERE borradoLogico = 0 " +
                            "AND nombre ="  + nombreCentroVenta ;


            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);


            if (resultado.Rows.Count > 0)
            {
                return this.MapearCentroVenta(resultado.Rows[0]);
            }

            return null;


        }

        public bool borradoLogicamente(int idCentroVenta)
        {
            string strSql = "UPDATE centroVenta  SET borradoLogico = 1" +
                               "WHERE idCentroVenta = " + idCentroVenta ;
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarCentroVenta(CentroVenta centroVenta)
        {
            string strSql = "UPDATE centroVenta  SET " +
                            "nombre = '" + centroVenta.Nombre + "'," +
                            "WHERE idCentroVenta = " + centroVenta.IdCentroVenta;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirCentroVenta(CentroVenta centroVenta)
        {
            string strSql = "INSERT INTO [dbo].[centroVenta] ([nombre])" +
                "VALUES ( '" + centroVenta.Nombre + "');";

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public DataTable recuperarFiltrados(string filtros)
        {       
            string strSql = "SELECT * " +
                            "from centroVenta  " +
                            "WHERE borradoLogico = 0 " + filtros;

            return BDConexion.getBDConexion().EjecutarSQL(strSql);

        }


        public CentroVenta MapearCentroVenta(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto Usuario

            // Recuperamos los atributos del usuario de SQL a C#
            
            string centroVentaNombre = row["nombre"].ToString();

 

            // Instanciamos el usuario recuperado de la BD
            CentroVenta centroVentaObj = new CentroVenta()
            {
                Nombre = centroVentaNombre,
            };

            return centroVentaObj;
        }
    }
}
