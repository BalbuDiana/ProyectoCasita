using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    abstract class Electro_master
    {
       
        
        protected double potencia;
        protected static double LimConsumo = 1000; //para saber cuando se apaga
        protected static double PotenciaMayor = 0; //para saber quien es el que consume mas   
        DateTime tiempoIni;		// En fecha
        double tiempoAcc;       // En horas 

        protected string ubicacion = ""; //es para saber la ubicacion del electrodomestico
        protected string id = " ";  //solo para saber, Para recorrer la lista
        protected bool estaPrendido; //para saber estado

        public Electro_master(double potencia, string id, string ubicacion ) //solo creamos un foco que esta en la cocina XD
        {
            this.ubicacion = ubicacion;
            this.id = id;
            this.potencia = potencia;
            estaPrendido = false;
            tiempoAcc = 0.0;
            if (potencia < PotenciaMayor)
            {
                PotenciaMayor = potencia;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------

        public abstract double Consumosuma();
    

        public abstract void Apagar(); //para cambiar estado
       

        public abstract void Prender();
       
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

    
        //-------------------------------------------------------------------------------------------------------------------

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

    }
}
