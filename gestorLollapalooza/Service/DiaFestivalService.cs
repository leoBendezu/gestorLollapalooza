using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.Service
{
    class DiaFestivalService
    {
        private DiaFestivalDao dao;

        public DiaFestivalService()
        {
            dao = new DiaFestivalDao();
        }

        public bool borrarLogicamente(int idDiaFestival)
        {
            // Metodo encargado de darle borrar de forma logica un DiaFestival, recibe como parametro:
            // * int idDiaFestival
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo borradoLogicamente()
            // Si se consigue borrar el DiaFestival se retorna true
            // en caso contrario retorna false

            return (this.dao.borradoLogicamente(idDiaFestival));
        }

        public IList<DiaFestival> RecuperarTodos()
        {
            // Metodo encargado de recuperar todos los DiaFestival de la base de datos, no recibe parametros
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo obtenerTodos()
            // Si se logra recuperar todos los DiaFestival retorna una lista de DiaFestival 

            IList<DiaFestival> diasFestivales = dao.obtenerTodos();
            return diasFestivales;

        }

        public bool modificarDiaFestival(DiaFestival diaFestival)
        {
            // Metodo encargado de modificar un DiaFestival, recibe como parametro:
            // * DiaFestival diaFestival
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo modificarDiaFestival()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return this.dao.modificarDiaFestival(diaFestival);
        }

        public bool PersistirUsuario(DiaFestival diaFestival)
        {
            // Metodo encargado de persistir un DiaFestival, recibe como parametro:
            // * DiaFestival diaFestival
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo persistirDiaFestival()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return dao.persistirDiaFestival(diaFestival);
        }


        public bool ExisteDiaFestival(int idDiaFestival)
        {
            // Metodo encargado de comprobar si un DiaFestival se encuentra en la bd, recibe como parametro:
            // * int idDiaFestival
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo recuperarDiaFestival()
            // Si se el DiaFestival se encuentra en la bd retorna true en caso contrario retorna false

            return (dao.recuperarDiaFestival(idDiaFestival) != null);
        }

        public DiaFestival recuperarDiaFestival(int idDiaFestival)
        {
            // Metodo encargado de traer un DiaFestival de la bd, recibe como parametro:
            // * int idDiaFestival
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo recuperarDiaFestival()
            // Si se logra recupear al DiaFestival retorna un DiaFestival

            return dao.recuperarDiaFestival(idDiaFestival);
        }

        public IList<DiaFestival> obtenerFiltados(string filtros)
        {
            // Metodo encargado de buscar DiaFestival en la bd en base a filtros, recibe como parametros:
            // * string filtros
            // utiliza al DiaFestivalDao para que realice la tarea mediante el metodo recuperarFiltrados()
            // si encuentra DiaFestival en base al filtro retorna una lista de DiaFestival

            return dao.recuperarFiltrados(filtros);
        }

    }
}
