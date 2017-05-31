using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto
{
    class Microondas:Electro_master
    {
        Image micro;
        
        public Microondas(string id)
            :base(1800,id,"Cocina")
        {
            
        }

        public override void CrearIcono()
        {
            micro = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\microondas.jpg");
        }

        public Image ObtenerIMagen()
        {
            return micro;
        }

    }
}
