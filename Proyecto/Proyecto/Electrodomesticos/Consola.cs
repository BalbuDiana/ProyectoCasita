using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Consola: Electro_master

    {
        Image consola;

        public Consola(string id, string ubicacion)
            :base(1200, id, ubicacion,"Consola")
        {
            this.tipo = "Consola";
        }

        public override void CrearIcono()
        {
            consola = Image.FromFile(@"Iconos\Consolajuegos.png");
        }

        public override Image ObtenerIMagen()
        {
            return consola;
        }
    }
}
