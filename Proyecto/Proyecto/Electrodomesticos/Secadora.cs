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
            :base(2891,id, ubicacion,"secadora")
        {
            
        }


        public override void CrearIcono()
        {
            secadora = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\secadora.png");
        }

        public Image ObtenerIMagen()
        {
            return secadora;
        }


    }
}
