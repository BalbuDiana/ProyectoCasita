using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Microondas:Electro_master
    {
       
        public Microondas(string id)
            :base(1000,id,"Kitchen")
        {
            this.ubicacion = "Kitche";

        }
    }
}
