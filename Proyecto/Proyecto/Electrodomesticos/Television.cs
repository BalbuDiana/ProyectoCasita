using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Proyecto.Electrodomesticos
{
    class Television: Electro_master
    {

        Image tv;
        public Television(string id, string ubicacion)
            :base(1456, id, ubicacion,"tv")
        {

        }
        public override void CrearIcono()
        {
            tv = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\televisor.png");
        }

        public Image ObtenerIMagen()
        {
            return tv;
        }
    }
}
