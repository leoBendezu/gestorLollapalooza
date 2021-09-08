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
        private string nombre;
        private int borrado;

        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = " Select * From Perfiles where borrado = 0 ";
            BDConexion oDatos = new BDConexion();
            return oDatos.ConsultaSQL(consulta);
        }
    }
}
