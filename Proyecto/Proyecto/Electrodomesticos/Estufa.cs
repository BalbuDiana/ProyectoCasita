﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    class Estufa: Electro_master
    {
        Image estufa;

        public Estufa( string id)
            :base(3456, id, "Cocina","estufa")
        {
            
        }

        public override void CrearIcono()
        {
            estufa = Image.FromFile(@"Iconos\estufa.jpg");
        }

        public override Image ObtenerIMagen()
        {
            return estufa;
        }

    }
}
