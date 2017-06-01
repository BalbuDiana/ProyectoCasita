using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Laptop:Electro_master
    {
        Image laptop;

        public Laptop(string id,string ubicacion)
            :base(2000, id, ubicacion,"laptop")
        {
           
        }

        public override void CrearIcono()
        {
            laptop = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\laptop.png");
        }

        public Image ObtenerIMagen()
        {
            return laptop;
        }


    }
}
