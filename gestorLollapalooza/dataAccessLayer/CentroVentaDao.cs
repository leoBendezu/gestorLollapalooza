using gestorLollapalooza.bussinesLayer;
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
        private PuntoVentaDao oPuntoVenta;
        public IList<CentroVenta> obtenerTodos()
        {

            List<CentroVenta> centrosVenta = new List<CentroVenta>();
        

            string strSql = "SELECT * " +
                         "from centroVenta  " +
                         "WHERE borradoLogico = 0 ";

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                centrosVenta.Add(this.MapearCentroVenta(row));
            }
            return centrosVenta;

        }


        public CentroVenta recuperarCentroVenta(string nombreCentroVenta)
        {

            string strSql = "SELECT * " +
                            "from centroVenta " +
                            "WHERE borradoLogico = 0 " +
                            "AND nombre ='"  + nombreCentroVenta + "'";


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
                            "nombre = '" + centroVenta.Nombre + "'" +
                            "WHERE idCentroVenta = " + centroVenta.IdCentroVenta;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirCentroVenta(CentroVenta centroVenta)
        {
            string strSql = "INSERT INTO [dbo].[centroVenta] ([nombre])" +
                "VALUES ( '" + centroVenta.Nombre + "');";

            int res = BDConexion.getBDConexion().ejecutarSQL(strSql);

            var newId = BDConexion.getBDConexion().ConsultaSQLScalar("SELECT IDENT_CURRENT('centroVenta')");


            if (res == 1)
            {
                this.oPuntoVenta = new PuntoVentaDao();

                foreach (PuntoVenta puntoVenta in centroVenta.puntosDeVenta)
                {
                    puntoVenta.IdCentroVenta = Convert.ToInt32(newId);
                    this.oPuntoVenta.persistirPuntoVenta(puntoVenta);
                }
            }
            return (res == 1);
        }

        public IList<CentroVenta> recuperarFiltrados(string filtros)
        {
            IList<CentroVenta> centrosVenta = new List<CentroVenta>();
            string strSql = "SELECT * " +
                            "from centroVenta  " +
                            "WHERE borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                centrosVenta.Add(this.MapearCentroVenta(row));
            }
            return centrosVenta;

        }


        public CentroVenta MapearCentroVenta(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto Usuario

            // Recuperamos los atributos del usuario de SQL a C#
            
            
            int idCentroVenta = Convert.ToInt32(row["idCentroVenta"]);
            string centroVentaNombre = row["nombre"].ToString();

 

            // Instanciamos el usuario recuperado de la BD
            CentroVenta centroVentaObj = new CentroVenta()
            {
                IdCentroVenta = idCentroVenta,
                Nombre = centroVentaNombre
            };

            return centroVentaObj;
        }
    }
}
