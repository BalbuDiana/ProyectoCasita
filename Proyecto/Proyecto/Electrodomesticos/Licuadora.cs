using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Licuadora:Electro_master
    {
        Image licuadora;

        public Licuadora(string id)
            :base(250,id,"Kitchen","licuadora")
        {
        }

        public override void CrearIcono()
        {
            licuadora = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\licuadora.png");
        }

        public override Image ObtenerIMagen()
        {
            return licuadora;
        }

    }
}
