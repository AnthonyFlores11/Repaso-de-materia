using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Buses : Automovil, IOperaciones, IAcciones<Buses>

    {
        //atributos

        private bool esPublico;
        private int fechaRevision;
        protected int costoPasaje;

        public bool EsPublico { get => esPublico; set => esPublico = value; }
        public int FechaRevision { get => fechaRevision; set => fechaRevision = value; }

        public Buses()
        {

        }

        public Buses(bool esPublico, int fechaRevision, int costoPasaje)
        {
            this.esPublico = esPublico;
            this.fechaRevision = fechaRevision;
            this.costoPasaje = costoPasaje;
        }

        public Buses(int cantLlantas, int cantPasajeros, bool esGasolina, string color, bool tieneRTV) 
            : base(cantLlantas, cantPasajeros, esGasolina, color, tieneRTV)
        {
        }

        public Buses(bool esPublico, int fechaRevision, int costoPasaje, int cantLlantas, int cantPasajeros, bool esGasolina, string color, bool tieneRTV)
            : base(cantLlantas, cantPasajeros, esGasolina, color, tieneRTV)
        {
            this.esPublico = esPublico;
            this.fechaRevision = fechaRevision;
            this.costoPasaje = costoPasaje;
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancar Bus");
        }

        public override void Detener()
        {
            Console.WriteLine("Detener Bus");
        }

        public void Insertar(int i)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int i)
        {
            throw new NotImplementedException();
        }

        public void Modificar(int id)
        {
            throw new NotImplementedException();
        }

        public int Buscar(int i)
        {
            throw new NotImplementedException();
        }

        public void cambiarAceite()
        {
            throw new NotImplementedException();
        }

        public int Cilindraje(Buses item)
        {
            throw new NotImplementedException();
        }

        public Buses cajaCambios(Buses item)
        {
            throw new NotImplementedException();
        }
    }
}
