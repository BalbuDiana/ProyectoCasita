using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Laptop
    {
        string ubicacion;
        int id = 0;
        double Potencia;
        public Laptop(double Potencia, string ubicacion)
        {
            this.Potencia = Potencia;
            this.ubicacion = ubicacion;
            id += 1;
        }
    }
}
