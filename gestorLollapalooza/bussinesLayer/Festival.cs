using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    class Festival
    {
        public int IdFestival { get; set; }
        public int AnoEdicion { get; set; }
        public int DescuentoVentaAnticipada { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Nombre { get; set; }
        public int PorcentajeDevolucionPorAnulacion { get; set; }
        public int Vigente { get; set; }
        public IList<DiaFestival> Dias { get; set; }

    }
}
