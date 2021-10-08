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
    class ActuacionService
    {
        private ActuacionDao dao;

        public IList<Actuacion> obtenerTodos()
        {
            return dao.obtenerTodos();
        }

        public Actuacion MapearActuacion(DataRow row)
        {
            return dao.MapearActuacion(row);
        }

        public bool persistirActuacion(Actuacion actuacion)
        {
            return dao.persistirActuacion(actuacion);
        }

        public IList<Actuacion> obtenerTodosDeDiaFestival(int idDiaFestival)
        {
            return dao.obtenerTodosDeDiaFestival(idDiaFestival);
        }
    }
}
