using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorLollapalooza.dataAccessLayer;

namespace gestorLollapalooza.bussinesLayer
{
    class Usuario
    {

        public int IdUsuario { get; set; }
        public Perfil PerfilUsuario { get; set; }

        public string UsuarioNombre { get; set; }

        public string Contrasena { get; set; }

        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int BorradoLogico { get; set; }

        private UsuarioDao oUsuario;

        
        public Usuario()
        {
            this.oUsuario = new UsuarioDao();
        }
                            

        public Usuario ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            Usuario usuarioRecuperado = oUsuario.recuperarUsuario(nombreUsuario);
            
            if(usuarioRecuperado != null && usuarioRecuperado.Contrasena.Equals(contrasena))
            {
                return usuarioRecuperado;
            } else
            {
                return null;
            }
        }


        public IList<Usuario> RecuperarTodos()
        {
            IList<Usuario> usuariosAll = oUsuario.obtenerTodos();
            return usuariosAll;

        }


        public bool PersistirUsuario(Usuario usuario)
        {
            return oUsuario.persistirUsuario(usuario);
        }


        public bool ExisteUsuario(string nombreUsuario)
        {
            return (oUsuario.recuperarUsuario(nombreUsuario) != null);
        }

        public IList<Usuario> obtenerFiltados(String filtros)
        {
            return oUsuario.recuperarFiltrados(filtros);
        }




    }
}
