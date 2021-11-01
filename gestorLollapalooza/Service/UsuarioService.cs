using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.Service
{
    class UsuarioService
    {
        private UsuarioDao oUsuario;

        public UsuarioService()
        {
            this.oUsuario = new UsuarioDao();
        }

        public Usuario ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            // Metodo encargado de autenticar al usuario, recibe como parametros:
            // * string NombreUsuario
            // * String contrasena
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarUsuario()
            // Si recupera un usuario compara la contraseña, si la contraseña coincide retorna el usuario
            // en caso contrario retorna null

            Usuario usuarioRecuperado = oUsuario.recuperarUsuario(nombreUsuario);

            if (usuarioRecuperado != null && usuarioRecuperado.Contrasena.Equals(contrasena))
            {
                return usuarioRecuperado;
            }
            else
            {
                return null;
            }
        }

        public bool borrarLogicamente(string usuarioNombre)
        {
            // Metodo encargado de darle borrar de forma logica un usuario, recibe como parametro:
            // * string NombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo borradoLogicamente()
            // Si se consigue borrar el usuario se retorna true
            // en caso contrario retorna false

            return (this.oUsuario.borradoLogicamente(usuarioNombre));
        }

        public IList<Usuario> RecuperarTodos()
        {
            // Metodo encargado de recuperar todos los usuarios de la base de datos, no recibe parametros
            // utiliza al usuarioDao para que realice la tarea mediante el metodo obtenerTodos()
            // Si se logra recuperar todos los usuarios retorna una lista de usuarios 

            IList<Usuario> usuariosAll = oUsuario.obtenerTodos();
            return usuariosAll;

        }

        public bool modificarUsuario(Usuario usuario)
        {
            // Metodo encargado de modificar un usuario, recibe como parametro:
            // * Usuario usuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo modificarUsuario()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return this.oUsuario.modificarUsuario(usuario);
        }

        public bool PersistirUsuario(Usuario usuario)
        {
            // Metodo encargado de persistir un usuario, recibe como parametro:
            // * Usuario usuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo persistirUsuario()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return oUsuario.persistirUsuario(usuario);
        }


        public bool ExisteUsuario(string nombreUsuario)
        {
            // Metodo encargado de comprobar si un usuario se encuentra en la bd, recibe como parametro:
            // * String nombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarUsuario()
            // Si se el usuario se encuentra en la bd retorna true en caso contrario retorna false

            return (oUsuario.recuperarUsuario(nombreUsuario) != null);
        }

        public Usuario recuperarUsuario(string nombreUsuario)
        {
            // Metodo encargado de traer un usuario de la bd, recibe como parametro:
            // * String nombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarUsuario()
            // Si se logra recupear al usuario  retorna un usuario

            return oUsuario.recuperarUsuario(nombreUsuario);
        }

        public IList<Usuario> obtenerFiltados(string filtros)
        {
            // Metodo encargado de buscar usuarios en la bd en base a filtros, recibe como parametros:
            // * string filtros
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarFiltrados()
            // si encuentra usuarios en base al filtro retorna una lista de usuarios

            return oUsuario.recuperarFiltrados(filtros);
        }

        public DataTable recuperarFiltradosReporte(String filtros)
        {
            return oUsuario.recuperarFiltradosReporte(filtros);
        }

        public DataTable recuperarTodosReporte()
        {
            return oUsuario.obtenerTodosReporte();
        }
    }
}
