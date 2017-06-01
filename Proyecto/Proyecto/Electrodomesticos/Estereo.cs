﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Estereo: Electro_master
    {
        Image estereo;

        public Estereo(string id, string ubicacion)
            :base(1342, id, ubicacion,"estereo")
        {

        }
        public override void CrearIcono()
        {
            estereo = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\estereo.png");
        }

        public override Image ObtenerIMagen()
        {
            return estereo;
        }

    }
}
