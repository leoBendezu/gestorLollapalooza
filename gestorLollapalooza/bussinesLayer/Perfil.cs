using gestorLollapalooza.dataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    class Perfil
    {
        private int idPerfil;
        private string nombrePerfil;
        private int borrado;

        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string Nombre { get => nombrePerfil; set => nombrePerfil = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = " Select * From perfiles where borradoLogico = 0 ";
            BDConexion oDatos = new BDConexion();
            return oDatos.EjecutarSQL(consulta);
        }
    }
}
