using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Pelota
    {
        Image pelota;
        public void CrearIcono()
        {
            pelota = Image.FromFile(@"Iconos\pelota.png");
        }

        public Image ObtenerIMagen()
        {
            return pelota;
        }
    }
}
