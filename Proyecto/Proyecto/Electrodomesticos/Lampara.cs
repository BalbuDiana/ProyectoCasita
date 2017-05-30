using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.Electrodomesticos
{
    class Lampara: Foco
    {
        public Lampara(string id, string ubicacion)
            :base(150,id,ubicacion)
        {

        }

        public void CrearIcono(Graphics g )
        {

            PictureBox lic = new PictureBox();

            Image licua = Image.FromFile("E:\\lic.png");

            lic.Image = licua;

               
        }
    }
}
