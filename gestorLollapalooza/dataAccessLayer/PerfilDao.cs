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
    
        public Perfil MapearPerfil(DataRow row)
        {
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
