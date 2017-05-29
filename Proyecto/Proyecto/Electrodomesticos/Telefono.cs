using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Electrodomesticos
{
    class Telefono: Electro_master
    {
        public Telefono(double potencia, string id, string ubicacion)
            :base(100, id, ubicacion)
        {

        }
    }
}
