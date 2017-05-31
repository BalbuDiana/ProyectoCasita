using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.Electrodomesticos
{
    class Lampara: Foco
    {
        Image lamp;

        public Lampara(string id, string ubicacion)
            :base(150,id,ubicacion)
        {

        }

        public override void CrearIcono() //Se harán override, porque vendrán de un método abstracto
        {
            // necesitamos meter todas las imágenes en un sola carpeta y hacer archivos locales para que se puede leer
            //Mitch, aquí necesitas poner tu ruta porque si no te marcará error a la hora de realizar tu programa en 
            // tu computadora
           lamp = Image.FromFile(@"E:\Visual Studio 2015\ProyectoCasita\Proyecto\Proyecto\Iconos\lampara.jpg");
            
             //*@"C:\Users\Balbu\Source\Repos\ProyectoCasita\Proyecto\Proyecto\lic.png"
        }

        public Image ObtenerIMagen()
        {
           
                return lamp;
        }
    }
}
