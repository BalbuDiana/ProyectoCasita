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

        public Foco(string id, string ubicacion)
            :base(100, id, ubicacion,"foco")

        {
            
        }

        public override void CrearIcono()
        {
            foco = Image.FromFile(@"C:\Users\Balbu\Source\Repos\ProyectoCasita2\Proyecto\Proyecto\Iconos\foquito.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return foco;
        }

    }
}
