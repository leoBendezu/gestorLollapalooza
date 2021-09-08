using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorLollapalooza.dataLayer;

namespace gestorLollapalooza.bussinesLayer
{
    class Usuario
    {
        private int id_usuario;
        private int id_perfil;
        private string usuarionombre;
        private string contrasena;
        private string email;
        private string nombre;
        private string apelido;
        private int borrado;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public string Usuarionombre { get => usuarionombre; set => usuarionombre = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Email { get => email; set => email = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public int Borrado { get => borrado; set => borrado = value; }


        public DataTable RecuperarTodos()
        {

            BDConexion sql = new BDConexion();
            string consulta = " Select u.idUsuario, u.usuario, u.password, u.email, u.nombre, u.apellido, p.nombre From Usuarios u Perfiles p where u.borrado = 0 and p.borrado = 0 and u.idPerfil = p.idPerfil";
            return sql.ConsultaSQL(consulta);

        }

        public DataTable
    }
}
