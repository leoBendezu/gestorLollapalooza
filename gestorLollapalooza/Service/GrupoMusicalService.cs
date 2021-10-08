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
    class GrupoMusicalService
    {
        private GrupoMusicalDao dao;

        public GrupoMusicalService()
        {
            dao = new GrupoMusicalDao();
        }

        public List<GrupoMusical> traerTodos()
        {
            return dao.RecuperarTodos();
        }

        public List<GrupoMusical> traerFiltrados(string filtros)
        {
            return dao.recuperarFiltrados(filtros);
        }

        public bool persistirGrupoMusical(GrupoMusical grupoMusical)
        {
            return dao.existeGrupoMusical(grupoMusical);
        }

        public bool existeGrupoMusical(string nombre)
        {
            return dao.existeGrupoMusical(nombre);
        }

        public GrupoMusical crear(string nombre, string descripcion, int cantIntegrantes)
        {
            GrupoMusical grupo = new GrupoMusical();
            grupo.Nombre = nombre;
            grupo.Descripcion = descripcion;
            grupo.CantIntegrantes = cantIntegrantes;
            return grupo;
        }
        public GrupoMusical recuperarGrupoMusical(string nombre)
        {
            return dao.recuperarGrupo(nombre);
        }

        public bool borrarGrupo(string nombre)
        {
            return dao.borradoLogicamente(nombre);
        }

        public bool modificarGrupo(GrupoMusical grupo)
        {
            return dao.modificarGrupoMusical(grupo);
        }
    }
}
