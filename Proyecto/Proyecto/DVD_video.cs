using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class DVD_video:Electro_master
    {
        
        public DVD_video( string id, string ubicacion)
            :base(1220,id,ubicacion)
        {
            this.id = id;
            this.ubicacion = ubicacion;
        }
    }
}
