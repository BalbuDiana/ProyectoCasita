﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto.Electrodomesticos
{
    class Telefono: Electro_master
    {
        Image telefono;
        public Telefono( string id, string ubicacion)
            :base(100, id, ubicacion,"telefono")
        {

        }

        public override void CrearIcono()
        {
            telefono = Image.FromFile(@"Iconos\telefono.png");
        }

        public override Image ObtenerIMagen()
        {
            return telefono;
        }
    }
}
