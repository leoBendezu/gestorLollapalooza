using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    class DiaFestival
    {
        public int IdDiaFestival { get; set; }
        public int Fecha { get; set; }
        public int FechaLimiteAnulacionEntrada { get; set; }
        public int FechaVtoVentaAnticipada { get; set; }
        public int HoraPresentacion { get; set; }
        public int IdFestival { get; set; }
        public IList<Actuacion> Actuaciones { get; set; }



    }
}
