using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.bussinesLayer
{
    // Clase de entidad , encargada de representar la entidad Perfil y resolver sus metodos.
    // Establece una relacion con la clase PerfilDao para poder realizar la comunicacion con la
    // capa encargada del acceso a datos.

    public class Perfil
    {

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int BorradoLogico { get; set; }


        public Perfil()
        {
        }


    }
}
