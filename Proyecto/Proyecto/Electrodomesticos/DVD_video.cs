using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class DVD_video:Electro_master
    {
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En horas 
        double P = 2890;

        public DVD_video( double Potencia, string id, string ubicacion)
            :base(Potencia, id,ubicacion)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.estaPrendido = false;
            Potencia = P;
            this.potencia = P;
            tiempoAcc = 0.0;
        }

        //--------------------------------------------------------------------------------------------------------------------

        public override double Consumosuma()  //para saber el consumo de estar prendido 
        {
            // SI el aparato esta actualmente prendido, se suma "temporalmente el tiempo que lleva encendido. 
            double tiempoAux = tiempoAcc;
            if (estaPrendido)
            {
                tiempoAux = tiempoAux + (DateTime.Now.Subtract(tiempoIni).TotalHours);
            }

            return base.potencia * tiempoAux; //me da el consumo de Wh
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
