using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Lavadora: Electro_master
    {
        Image lavadora;

        public Lavadora(double potencia, string id, string ubicacion)
            :base(potencia, id, ubicacion,"lavadora")
        {

        }
        public override void CrearIcono()
        {
            lavadora = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\lavadora.png");
        }

        public override Image ObtenerIMagen()
        {
            return lavadora;
        }

    }
}
