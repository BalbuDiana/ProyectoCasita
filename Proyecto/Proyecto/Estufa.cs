﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Estufa: Electro_master
    {
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En hora 
        double Potencia;

        public Estufa(double Potencia, string id)
            :base(Potencia, id, "Cocina")
        {
            this.ubicacion = "Cocina";
            this.estaPrendido = false;
            this.Potencia = Potencia;
            this.potencia = Potencia;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public override double Consumosuma() //para saber el consumo de estar prendido 
        {
            // SI el aparato esta actualmente prendido, se suma "temporalmente el tiempo que lleva encendido. 
            double tiempoAux = tiempoAcc;
            if (estaPrendido)
            {
                tiempoAux = tiempoAux + (DateTime.Now.Subtract(tiempoIni).TotalHours);
            }

            return Potencia * tiempoAux; //me da el consumo de Wh
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
