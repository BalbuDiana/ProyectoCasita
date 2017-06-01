using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Foco: Electro_master
    {
        Image foco;

        public Foco(double potencia, string id, string ubicacion)
            :base(potencia, id, ubicacion,"foco")

        {
            
        }

        public override void CrearIcono()
        {
            foco = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\foquito.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return foco;
        }

    }
}
