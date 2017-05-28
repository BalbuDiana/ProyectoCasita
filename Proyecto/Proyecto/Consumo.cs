using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
   abstract class Consumo
    {
        double potencia;
        protected bool estaPrendido; //para saber estado 
        private static double LimConsumo = 1000; //para saber cuando se apaga
        private static double PotenciaMayor = 0; //para saber quien es el que consume mas   
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En horas 

        public double Consumosuma()
        {
            // SI el foco esta actualmente prendido, se suma "temporalmente el tiempo que lleva encendido. 
            double tiempoAux = tiempoAcc;
            if (estaPrendido)
            {
                tiempoAux = tiempoAux + (DateTime.Now.Subtract(tiempoIni).TotalHours);
            }

            return potencia * tiempoAux; //me da el consumo de Wh
        }


        public void Apagar()
        {
            if (estaPrendido)
            {
                estaPrendido = false;
                DateTime tiempoFin = DateTime.Now; //es local porque no se utiliza en otro lugar

                // Al operar DateTime (sumar, restart, etc ),  nos devuelve una objeto
                // de tipo TimeSpan, el cual representa un intervalo de tiempo (no una fecha)
                // Este intervalos lo podemos obtener en horas la variable TotalHours.
                tiempoAcc = tiempoAcc + (tiempoFin.Subtract(tiempoIni).TotalHours);
            }
        }


        public void Prender()
        {
            if (!estaPrendido)
            {
                estaPrendido = true;
                tiempoIni = DateTime.Now; //guardo el tiempo 
            }
        }

    }
}
