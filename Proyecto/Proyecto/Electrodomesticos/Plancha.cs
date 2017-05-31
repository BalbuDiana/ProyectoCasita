using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Proyecto
{
    class Plancha: Electro_master
    {
        Image plancha;

        public Plancha (string id, string ubicacion)
            :base(1234,id, ubicacion)
        {
            
        }

        public override void CrearIcono()
        {
            plancha = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\Plancha.png");
        }

        public Image ObtenerIMagen()
        {
            return plancha;
        }
    }
}
