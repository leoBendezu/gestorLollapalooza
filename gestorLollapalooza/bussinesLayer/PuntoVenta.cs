using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    class PuntoVenta
    {
        public int IdPuntoVenta { get; set; }
        public string NombrePuntoVenta { get; set; }
        public int NumeroPuntoVenta { get; set; }
        public int IdCentroVenta { get; set; }
        public int BorradoLogico { get; set; }

        public PuntoVenta()
        {

        }
    }
}
