using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Proyecto
{
    class hombre
    {
        Image hombr;
        public void CrearIcono()
        {
            hombr = Image.FromFile(@"Iconos\roboth.png");
        }

        public Image ObtenerIMagen()
        {
            return hombr;
        }
    }
}
