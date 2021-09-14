using gestorLollapalooza.bussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.dataAccessLayer
{
    class UsuarioDao
    {
        public IList<Usuario> obtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            var strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
                         "from usuarios u JOIN perfiles p ON(u.idPerfil = p.idPerfil) " +
                         "WHERE u.borradoLogico = 0 ";


            var resultadoConsulta = BDConexion.getBDConexion().EjecutarSQL(strSql);

            foreach( DataRow row in resultadoConsulta.Rows)
            {
                usuarios.Add(this.MapearUsuario(row));
            }
            return usuarios;
        }


        public Usuario recuperarUsuario(string nombreUsuario)
        {
           
            String strSql = "SELECT u.*, p.idPerfil, p.nombrePerfil " +
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


        public bool persistirUsuario(Usuario usuario)
        {
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

        internal IList<Usuario> recuperarFiltrados(string filtros)
        {
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


        public Usuario MapearUsuario(DataRow row)
        {

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
