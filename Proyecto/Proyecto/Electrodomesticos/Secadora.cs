using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Secadora: Electro_master
    {
        Image secadora;
       
        public Secadora(string id, string ubicacion)
            :base(2891,id, ubicacion)
        {
            
        }


        public override void CrearIcono()
        {
            secadora = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\secadora.png");
        }

        public Image ObtenerIMagen()
        {
            return secadora;
        }


    }
}
