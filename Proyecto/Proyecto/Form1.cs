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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double potencia = Convert.ToDouble(textBox1.Text);
            Microondas m = new Microondas("dos",potencia);

            m.Prender();
            if (m.GetEstaPrendido() == true)
            {
                MessageBox.Show("Esta prendido Microondas con potencia de :" + m.GetPotencia() + "\n Consumo = " +m.Consumosuma());
                //m.Apagar();
            }
            else
            {

                MessageBox.Show("No esta prendido");
              
            }
           

            MessageBox.Show("Esta apagado Microondas con potencia de :" +m.GetId()+ "\n Consumo = " + m.Consumosuma());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double potencia = Convert.ToDouble(textBox1.Text);
            Licuadora m = new Licuadora(potencia, "uno");

            m.Prender();
            if (m.GetEstaPrendido() == true)
            {
                MessageBox.Show("Esta prendido Microondas con potencia de :" + m.GetPotencia() + "\n Consumo = " + m.Consumosuma());
                //m.Apagar();
            }
            else
            {

                MessageBox.Show("No esta prendido");

            }


            MessageBox.Show("Esta apagado Microondas con potencia de :" + m.GetId() + "\n Consumo = " + m.Consumosuma());
        }
    }
}
