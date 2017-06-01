﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Consola: Electro_master

    {
        Image consola;

        public Consola(string id, string ubicacion)
            :base(1200, id, ubicacion,"Consola")
        {
            this.tipo = "Consola";
        }

        public override void CrearIcono()
        {
            consola = Image.FromFile(@"C:\Users\Sagrario\Source\Repos\ProyectoCasita\ProyectoCasita\Proyecto\Proyecto\Iconos\Consolajuegos.png");
        }

        public Image ObtenerIMagen()
        {
            return consola;
        }
    }
}
