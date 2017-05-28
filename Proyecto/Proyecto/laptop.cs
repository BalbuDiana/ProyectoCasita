using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Laptop:Electro_master
    {

        double potencia;
        private static double LimConsumo = 1000; //para saber cuando se apaga
        private static double PotenciaMayor = 0; //para saber quien es el que consume mas   
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En horas 

        public Laptop(string id,string ubicacion)
            :base(6350,id, ubicacion)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.estaPrendido = false;
          
        }

        //---------------------------------------------------------------------------------------------------------------
        public override double Consumosuma()  //para saber el consumo de estar prendido 
        {
            // SI el aparato esta actualmente prendido, se suma "temporalmente el tiempo que lleva encendido. 
            double tiempoAux = tiempoAcc;
            if (estaPrendido)
            {
                tiempoAux = tiempoAux + (DateTime.Now.Subtract(tiempoIni).TotalHours);
            }

            return potencia * tiempoAux; //me da el consumo de Wh
        }


        public override void Apagar() //para cambiar estado
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


        public override void Prender() //para cambiar el estado inicial 
        {
            if (!estaPrendido)
            {
                estaPrendido = true;
                tiempoIni = DateTime.Now; //guardo el tiempo 
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

    }
}
