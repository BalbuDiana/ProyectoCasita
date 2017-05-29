using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Electrodomesticos
{
    class Lavadora: Electro_master
    {
        public Lavadora(double potencia, string id, string ubicacion)
            :base(potencia, id, ubicacion)
        {

        }
    }
}
