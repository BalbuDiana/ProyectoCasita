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
            :base(potencia, id, ubicacion)
        {

        }
        public override void CrearIcono()
        {
            lavadora = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\lavadora.png");
        }

        public Image ObtenerIMagen()
        {
            return lavadora;
        }

    }
}
