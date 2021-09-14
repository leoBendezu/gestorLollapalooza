using gestorLollapalooza.dataAccessLayer;
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

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int BorradoLogico { get; set; }

        private PerfilDao oPerfil;

        public Perfil()
        {
            this.oPerfil = new PerfilDao();
        }

        public IList<Perfil> RecuperarTodos()
        {
            return this.oPerfil.obtenerTodos();
        }
    }
}
