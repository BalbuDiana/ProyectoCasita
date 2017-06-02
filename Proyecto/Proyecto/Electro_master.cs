using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto
{
    public abstract class Electro_master
    {

        double potencia;
        protected string tipo;
        protected static double LimConsumo = 10000; //para saber cuando se apaga
        protected static double PotenciaMayor = 0; //para saber quien es el que consume mas   
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En horas 

        protected string ubicacion = ""; //es para saber la ubicacion del electrodomestico
        protected string id = " ";  //solo para saber, Para recorrer la lista
        protected bool estaPrendido; //para saber estado

        public Electro_master(double potencia, string id, string ubicacion, string tipo) //solo creamos un foco que esta en la cocina XD
        {
            this.ubicacion = ubicacion;
            this.id = id;
            this.tipo = tipo;
            this.potencia = potencia; //Wh
            estaPrendido = false;
            tiempoAcc = 0.0;
            if (potencia < PotenciaMayor)
            {
                PotenciaMayor = potencia;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------

        public virtual double Consumosuma()  //para saber el consumo de estar prendido 
        {
            // SI el aparato esta actualmente prendido, se suma "temporalmente el tiempo que lleva encendido. 
            double tiempoAux = tiempoAcc;
            if (estaPrendido)
            {
                tiempoAux = tiempoAux + (DateTime.Now.Subtract(tiempoIni).TotalHours);
            }

            return potencia * tiempoAux; //me da el consumo de Wh
        }


        public virtual void Apagar() //para cambiar estado
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


        public virtual void Prender() //para cambiar el estado inicial 
        {
            if (!estaPrendido)
            {
                estaPrendido = true;
                tiempoIni = DateTime.Now; //guardo el tiempo 
            }
        }



        //-------------------------------------------------------------------------------------------------------------------

        public bool AltoConsumo() //para saber cuando es muy alto su consumo
        {
            double ConsumoActual = Consumosuma();
            //todos los aparatos tendran el mismo consumo por eso es static
            if (ConsumoActual > LimConsumo)
            {
                return true;
            }

            return false;
        }

        //----------------------------------------------------------------------------------------------------------------
        //-----  Crear Icono

        abstract public void CrearIcono(); //Esta es la firma del método que tendrán todos

        abstract public Image ObtenerIMagen();



        public static void SetLimConsumo(double valor) //para cambiar //no regresa nada
        {
            LimConsumo = valor;

        }

        public static double GetPotenciaMayor() //para saber el aparato con mayor potencia
        {
            return PotenciaMayor;
        }

        public double GetPotencia() //es para saaber su potencia 
        {
            return potencia;

        }

        public string GetId() //Es para saber el nombre del que se creo
        {
            return id;
        }


        public string GetUbicacion() //es para saber donde se creo
        {
            return ubicacion;
        }

        public bool GetEstaPrendido()
        {
            return estaPrendido;
        }

      public string Gettipo()
        {
            return tipo;
        }

       
      

    }
}
