﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Electrodomesticos
{
    class Television: Electro_master
    {
        public Television(double potencia, string id, string ubicacion)
            :base(potencia, id, ubicacion)
        {

        }
    }
}