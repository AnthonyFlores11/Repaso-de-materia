using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Automovil
    {
         //Ejemplo de clase abstracta
      private  int _cantLlantas;
        private int _cantPasajeros;
        private bool esGasolina;
        private string color;
        private bool tieneRTV;

        public int CantLlantas { get => _cantLlantas; set => _cantLlantas = value; }
        public int CantPasajeros { get => _cantPasajeros; set => _cantPasajeros = value; }
        public bool EsGasolina { get => esGasolina; set => esGasolina = value; }
        public int CantLlantas1 { get => _cantLlantas; set => _cantLlantas = value; }
        public int CantPasajeros1 { get => _cantPasajeros; set => _cantPasajeros = value; }
        public bool EsGasolina1 { get => esGasolina; set => esGasolina = value; }
        protected string Color { get => color; set => color = value; }
        public bool TieneRTV { get => tieneRTV; set => tieneRTV = value; }

        protected Automovil()
        {

        }

        protected Automovil(int cantLlantas, int cantPasajeros, bool esGasolina, string color, bool tieneRTV)
        {
          _cantLlantas = cantLlantas;
            _cantPasajeros = cantPasajeros;
            this.esGasolina = esGasolina;
            this.color = color;
           this.tieneRTV = tieneRTV;
       }



        // Metodos

        public abstract void Arrancar(); //Contrato se tiene que implementar pero no como

        public virtual void Detener() // Puede hacer su misma implementacion o la del padre
        {
            Console.WriteLine("Detener Automovil");
        }

        public void Manejar() // hijo puede utilizarlo pero no obligado
        {

        }
    }
}
