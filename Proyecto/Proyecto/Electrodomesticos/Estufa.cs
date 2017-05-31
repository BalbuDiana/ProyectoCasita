using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Estufa: Electro_master
    {
        Image estufa;

        public Estufa( string id)
            :base(3456, id, "Cocina")
        {
            
        }

        public override void CrearIcono()
        {
            estufa = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\estufa.png");
        }

        public Image ObtenerIMagen()
        {
            return estufa;
        }

    }
}
