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
            :base(2890, id,ubicacion)
        {
        }

        public override void CrearIcono()
        {
           dvd = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\dvd.png");
        }

        public Image ObtenerIMagen()
        {
            return dvd;
        }
    }
}
