﻿using System;
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
            string consulta = " Select u.idUsuario, u.usuario, u.password, u.email, u.nombre, u.apellido, p.nombrePerfil " +
                "From Usuarios u join Perfiles p on (u.borradoLogico = 0 and p.borradoLogico = 0 and u.idPerfil = p.idPerfil)";
            return sql.ConsultaSQL(consulta);

        }

        public DataTable RecuperarFiltrados(string usuario, string nombre, string apellido, string nombrePerfil)
        {
            BDConexion sql = new BDConexion();
            string consulta = " Select u.idUsuario, u.usuario, u.password, u.email, u.nombre, u.apellido, p.nombrePerfil " +
                "From Usuarios u join Perfiles p on (u.borradoLogico = 0 and p.borradoLogico = 0 and u.idPerfil = p.idPerfil";
            if (!string.IsNullOrEmpty(usuario))
                consulta += " and u.idUsuario=" + usuario;
            if (!string.IsNullOrEmpty(nombre))
                consulta += " and u.nombre=" + nombre;
            if (!string.IsNullOrEmpty(usuario))
                consulta += " and u.apellido=" + apellido;
            if (!string.IsNullOrEmpty(nombrePerfil))
                consulta += " and p.nombrePerfil=" + nombrePerfil;
            consulta += ")";
            return sql.ConsultaSQL(consulta);
        }

        
    }
}