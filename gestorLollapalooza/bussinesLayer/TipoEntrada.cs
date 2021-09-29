using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    class TipoEntrada
    {
        public int IdTipoEntrada { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int BorradoLogico { get; set; }

        public TipoEntrada()
        {

        }
    }
}
