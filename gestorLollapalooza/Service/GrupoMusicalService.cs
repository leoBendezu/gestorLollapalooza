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

        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable traerFiltrados(string filtros)
        {
            return dao.recuperarFiltrados(filtros);
        }

        public bool persistirGrupoMusical(GrupoMusical grupoMusical)
        {
            return dao.persistirGrupoMusical(grupoMusical);
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
    }
}
