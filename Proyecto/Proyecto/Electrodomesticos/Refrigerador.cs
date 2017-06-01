using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Refrigerador: Electro_master
    {
        Image refri;

        public Refrigerador(string id, string ubicacion)
            :base(1050, id, ubicacion,"refri")
        {

        }
        public override void CrearIcono()
        {
            refri = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\refrigerador.jpg");
        }

        public Image ObtenerIMagen()
        {
            return refri;
        }

    }
}
