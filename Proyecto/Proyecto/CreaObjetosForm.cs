using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class CreaObjetosForm : Form
    {
 
        public CreaObjetosForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  string id = textBox1.Text;

           // Electro_master busqueda = null;

            //dudas
            //f1.prender(id);

                        //   if (f1.prender(id)==true)
                           // {
                             // label3.Text = "Esta Prendido";
                             //}
          /* 
            for (int i = 0; i < listadeObjetos.Count() ; i++)
            {
                if (id == listadeObjetos[i].id)
                {
                    busqueda = listadeObjetos[i];
                }


            }
            if (busqueda == null)
            {
                MessageBox.Show("El id no existe, intentalo de nuevo");
            }
            busqueda.Prender();
            label3.Text = "Esta Prendido";
            */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string id = textBox1.Text;

            Electro_master busqueda = null;

            for (int i = 0; i < listadeObjetos.Count(); i++)
            {
                if (id == listadeObjetos[i].id)
                {
                    busqueda = listadeObjetos[i];
                }
            }
            if (busqueda == null)
            {
                MessageBox.Show("El id no existe, intentalo de nuevo");
            }

            busqueda.Apagar();
            label3.Text = "Esta Apagado";*/
        }
    }
    }
