using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    public class DiaFestival
    {
        public int IdDiaFestival { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaLimiteAnulacionEntrada { get; set; }
        public DateTime FechaVtoVentaAnticipada { get; set; }
        public int IdFestival { get; set; }
        public IList<Actuacion> Actuaciones { get; set; }



    }
}
