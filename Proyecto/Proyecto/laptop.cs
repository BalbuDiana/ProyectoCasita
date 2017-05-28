using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Laptop:Electro_master
    {
       
        public Laptop(string id,string ubicacion)
            :base(6350,id, ubicacion)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.estaPrendido = false;
          
        }
    }
}
