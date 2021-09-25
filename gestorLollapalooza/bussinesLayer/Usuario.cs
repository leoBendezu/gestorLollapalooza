using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorLollapalooza.dataAccessLayer;

namespace gestorLollapalooza.bussinesLayer
{
    // Clase de entidad , encargada de representar la entidad usuarios y resolver sus metodos.
    // Establece una relacion con la clase UsuarioDao para poder realizar la comunicacion con la
    // capa encargada del acceso a datos.

    public class Usuario
    {   
        public int IdUsuario { get; set; }
        public Perfil PerfilUsuario { get; set; }

        public string UsuarioNombre { get; set; }

        public string Contrasena { get; set; }

        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int BorradoLogico { get; set; }

        public Usuario() { }

    }
}
