using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Electrodomesticos
{
    class Lampara: Foco
    {
        public Lampara(string id, string ubicacion)
            :base(150,id,ubicacion)
        {

        }
    }
}
