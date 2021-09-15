using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    // Clase de entidad , encargada de representar la entidad Perfil y resolver sus metodos.
    // Establece una relacion con la clase PerfilDao para poder realizar la comunicacion con la
    // capa encargada del acceso a datos.

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
            // Metodo encargado de recuperar todos los perfiles de la base de datos, no recibe parametros
            // utiliza al PerfilDao para que realice la tarea mediante el metodo obtenerTodos()
            // Si se logra recuperar todos los perfiles retorna una lista de perfiles 

            return this.oPerfil.obtenerTodos();
        }
    }
}
