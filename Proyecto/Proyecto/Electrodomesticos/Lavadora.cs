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

        public override void Apagar()
        {
            throw new NotImplementedException();
        }

        public override double Consumosuma()
        {
            throw new NotImplementedException();
        }

        public override void Prender()
        {
            throw new NotImplementedException();
        }
    }
}
