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
        Image licua;

        public Lampara(string id, string ubicacion)
            :base(150,id,ubicacion)
        {

        }

        public void CrearIcono() //Se harán override, porque vendrán de un método abstracto
        {
            // necesitamos meter todas las imágenes en un sola carpeta y hacer archivos locales para que se puede leer
            //Mitch, aquí necesitas poner tu ruta porque si no te marcará error a la hora de realizar tu programa en 
            // tu computadora
           licua = Image.FromFile(@"C:\Users\Balbu\Source\Repos\ProyectoCasita\Proyecto\Proyecto\lic.png");
          
        }

        public   Image ObtenerIMagen()
        {
            return licua;
        }
    }
}
