using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class osito
    {
        Image osit;
        public void CrearIcono()
        {
            osit = Image.FromFile(@"Iconos\osito.png");
        }

        public Image ObtenerIMagen()
        {
            return osit;
        }
    }
}
