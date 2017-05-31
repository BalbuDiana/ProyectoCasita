using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto
{
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            string[] series = {"H.Huéspedes","WC","Habitación","Cocina","Comedor","Sala" }; //se declaran los vectores con los datos de la grafica
            double[] puntos = {10, 20,30,40,50,60};

            chart1.Titles.Add("Consumo");

            for (int i = 0; i < series.Length; i++)
            {
                Series s = chart1.Series.Add(series[i]);// para los títulos

                s.Label = puntos[i].ToString();

                s.Points.Add(puntos[i]);

            
            }

            Form1 n = new Form1();
            Lblista.Text = n.imprimir_lista();
        }


    }
}
