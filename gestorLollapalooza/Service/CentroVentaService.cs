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
    class CentroVentaService
    {
        private CentroVentaDao dao;

        public CentroVentaService()
        {
            this.dao = new CentroVentaDao();
        }


        public bool borrarLogicamente(int idCentroVenta)
        {
            return (this.dao.borradoLogicamente(idCentroVenta));
        }

        public DataTable RecuperarTodos()
        {
            return dao.obtenerTodos();
        }

        public bool modificarCentroVenta(CentroVenta centroVenta)
        {
            return this.dao.modificarCentroVenta(centroVenta);
        }

        public bool PersistirCentroVenta(CentroVenta centroVenta)
        {
            return dao.persistirCentroVenta(centroVenta);
        }


        public CentroVenta recuperarCentroVenta(string nombreCentroVenta)
        {
            return dao.recuperarCentroVenta(nombreCentroVenta);
        }

        public DataTable obtenerFiltados(string filtros)
        {
            return dao.recuperarFiltrados(filtros);
        }

        public bool ExisteCentroVenta(string nombreCentro)
        {
            return (dao.recuperarCentroVenta(nombreCentro) != null);
        }
    }
}
