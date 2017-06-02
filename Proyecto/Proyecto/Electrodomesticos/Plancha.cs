﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Proyecto
{
    class Plancha: Electro_master
    {
        Image plancha;

        public Plancha (string id, string ubicacion)
            :base(1234,id, ubicacion,"plancha")
        {
            
        }

        public override void CrearIcono()
        {
            plancha = Image.FromFile(@"Iconos\Plancha.png");
        }

        public override Image ObtenerIMagen()
        {
            return plancha;
        }
    }
}
