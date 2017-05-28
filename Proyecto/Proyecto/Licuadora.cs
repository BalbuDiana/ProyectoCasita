using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Licuadora:Electro_master
    {
        string ubicacion;

        public Licuadora(string id)
            :base(450,id,"Kitchen")
        {
            this.ubicacion = "Kitchen";
            this.id = id;
            this.estaPrendido = false;
        }
    }
}
