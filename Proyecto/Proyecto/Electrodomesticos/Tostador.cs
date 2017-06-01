using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Tostador : Electro_master
    {
        Image tostador;
        public Tostador(string id)
            : base(238, id, "Cocina","tostador")
        {
        }

        public override void CrearIcono()
        {
            tostador = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\tostador.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return tostador;
        }

    }
}
