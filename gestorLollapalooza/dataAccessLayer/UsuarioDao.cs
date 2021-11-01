using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    // Clase encargada de conectarse con la BD y interactar con ella
    // para dar alta, baja, modificacion y consulta de Usuarios.

    class UsuarioDao
    {
        public IList<Usuario> obtenerTodos()
        {
            // Metodo encargado de recuperar todos los usuarios de la Base de datos, no recibe parametros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.
            
            List<Usuario> usuarios = new List<Usuario>();

            string strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                         "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                         "WHERE u.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach( DataRow row in resultadoConsulta.Rows)
            {
                usuarios.Add(this.MapearUsuario(row));
            }
            return usuarios;
        }


        public DataTable obtenerTodosReporte()
        {
            // funciona igual que el obtenerTodos, pero retorna un datatable y lo usamos para los reportes

            List<Usuario> usuarios = new List<Usuario>();

            string strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                         "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                         "WHERE u.borradoLogico = 0 ";


            return BDConexion.getBDConexion().EjecutarSQL(strSql);
        }


        public Usuario recuperarUsuario(string nombreUsuario)
        {
            // Metodo encargado de recuperar un usuario especifico de la Base de datos, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea por lo menos una fila, de ser asi la convierte en 
            // un objeto usuario mediante el metodo MapearUsuario(), luego retorna dicho usuario.

            string strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                            "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                            "WHERE u.borradoLogico = 0 " +
                            " AND usuario=" + "'" + nombreUsuario + "'";

          
            var resultado = BDConexion.getBDConexion().EjecutarSQL(strSql);
            
            if (resultado.Rows.Count > 0)
            {
                return this.MapearUsuario(resultado.Rows[0]);
            }

            return null;
        }

        public bool borradoLogicamente(string usuarioNombre)
        {
            // Metodo encargado de darle borrado logico a un usuario, recibe como parametros:
            // * String nombreUsuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE USUARIOS  SET borradoLogico = 1" + 
                               "WHERE usuario= '" + usuarioNombre + "'";
            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool modificarUsuario(Usuario usuario)
        {
            // Metodo encargado modificar los datos de un usuario, recibe como parametros:
            // * Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "UPDATE USUARIOS  SET " +
                            "usuario = '" + usuario.UsuarioNombre + "'," + 
                            "password = '" + usuario.Contrasena + "'," +
                            "email = '" + usuario.Email + "'," +
                            "nombre = '" + usuario.Nombre + "'," +
                            "apellido = '" + usuario.Apellido + "'," + 
                            "idPerfil = " + usuario.PerfilUsuario.IdPerfil.ToString() +
                            "WHERE idUsuario = " + usuario.IdUsuario.ToString() ;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1);
        }

        public bool persistirUsuario(Usuario usuario)
        {
            // Metodo encargado de guardar un usuario en la base de datos, recibe como parametros:
            // Usuario usuario
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Revisa que el resultado de la consulta sea correco ( igual a 1 )
            // en caso de serlo retorna true en caso contrario retorna false

            string strSql = "INSERT INTO [dbo].[usuarios] ([idPerfil], [usuario], [password], [nombre], [apellido], [email])" +
                "VALUES ( " + 
                usuario.PerfilUsuario.IdPerfil + " , '" + 
                usuario.UsuarioNombre + "' , '" +
                usuario.Contrasena + "' , '" + 
                usuario.Nombre + "' , '" + 
                usuario.Apellido + "' , '" + 
                usuario.Email + "');" ;

            return (BDConexion.getBDConexion().ejecutarSQL(strSql) == 1); 
        }

        public IList<Usuario> recuperarFiltrados(string filtros)
        {            
            // Metodo encargado de recuperar todos los usuarios de la Base de datos que cumplan con ciertos filtros,
            // recibe como parametros:
            // * String filtros
            // Se conecta con el BDhelper para ejecutar la consulta strSql.
            // Recorre el resultado de la consulta convirtiendo cada fila en un objeto usuario mediante el metodo
            // MapearUsuario(), luego retorna una lista con los usuarios.
                
            IList<Usuario> usuarios = new List<Usuario>();
            string strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                            "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                            "WHERE u.borradoLogico = 0 " + filtros;

            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                usuarios.Add(this.MapearUsuario(row));
            }
            return usuarios;
        }


        public DataTable recuperarFiltradosReporte(string filtros)
        {
            // Funciona igual que el recuperarFiltrados pero devuelve las cosas en forma de datatable para facilitarle la vida a los pobres que hacen el reporte

            IList<Usuario> usuarios = new List<Usuario>();
            string strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                            "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                            "WHERE u.borradoLogico = 0 " + filtros;

            return BDConexion.getBDConexion().EjecutarSQL(strSql);

            
        }


        public Usuario MapearUsuario(DataRow row)
        {

            // Metodo encargado de convertir una fila en un objeto Usuario

            // Recuperamos los atributos del usuario de SQL a C#
            int idUsuario = Convert.ToInt32(row["idUsuario"].ToString());
            string usuarioNombre = row["usuario"].ToString();
            string password = row["password"].ToString();
            string nombre = row["nombre"].ToString();
            string apellido = row["apellido"].ToString();
            string email = row["email"].ToString();

            // Recuperamos los atributos del perfil del usuario de SQL a C#

            int idPerfil = Convert.ToInt32(row["idPerfil"].ToString());
            string nombrePerfil = row["nombrePerfil"].ToString();


            // Instanciamos el perfil recuperado de la BD
            Perfil perfil = new Perfil()
            {
                IdPerfil = idPerfil,
                NombrePerfil = nombrePerfil
                
            };

            // Instanciamos el usuario recuperado de la BD
            Usuario usuarioObj = new Usuario()
            {
                IdUsuario = idUsuario,
                UsuarioNombre = usuarioNombre,
                Contrasena = password,
                Nombre = nombre,
                Apellido = apellido,
                Email  = email,
                PerfilUsuario = perfil
            };

            return usuarioObj;
        }
    }
}
