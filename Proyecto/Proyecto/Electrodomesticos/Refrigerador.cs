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
            refri = Image.FromFile(@"Iconos\refrigerador.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return refri;
        }

    }
}
