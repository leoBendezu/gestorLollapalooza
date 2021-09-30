using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    public class CentroVenta
    {
        public int IdCentroVenta { get; set; }
        public string Nombre { get; set; }
        public IList<PuntoVenta> puntosDeVenta { get; set; }
    }
}
