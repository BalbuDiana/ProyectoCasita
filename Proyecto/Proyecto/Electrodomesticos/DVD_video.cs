using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class DVD_video:Electro_master
    {
        Image dvd;
       
        public DVD_video(string id, string ubicacion)
            :base(2890, id,ubicacion,"dvd")
        {
        }

        public override void CrearIcono()
        {
           dvd = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\dvd.png");
        }

        public Image ObtenerIMagen()
        {
            return dvd;
        }
    }
}
