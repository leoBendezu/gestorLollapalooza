using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.Service
{
    class PerfilService
    {
        private PerfilDao oPerfil;

        public PerfilService()
        {
            this.oPerfil = new PerfilDao();
        }


        public IList<Perfil> RecuperarTodos()
        {
            // Metodo encargado de recuperar todos los perfiles de la base de datos, no recibe parametros
            // utiliza al PerfilDao para que realice la tarea mediante el metodo obtenerTodos()
            // Si se logra recuperar todos los perfiles retorna una lista de perfiles 

            return this.oPerfil.obtenerTodos();
        }
    }
}
