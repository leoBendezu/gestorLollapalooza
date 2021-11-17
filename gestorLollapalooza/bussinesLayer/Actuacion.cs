using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    public class Actuacion
    {
        public int IdActuacion { get; set; }
        public int DuracionActuacion { get; set; }
        public int NumeroOrden { get; set; }
        public GrupoMusical GrupoMusical { get; set; }


    }
}
