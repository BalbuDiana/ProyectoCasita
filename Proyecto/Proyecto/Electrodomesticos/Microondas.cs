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
            :base(1800,id,"Cocina","micro")
        {
            
        }

        public override void CrearIcono()
        {
            micro = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\microondas.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return micro;
        }

    }
}
