using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class manejoAutomoviles
    {
        List<Carros> listaCarros = new List<Carros>();
        List<Buses> listaBus = new List<Buses>();
        List<Automovil> listaAuto = new List<Automovil>();


        public void agregarAutomovil(Automovil item)
        {
            listaAuto.Add(item);
        }

        public void Carros(Carros item)
        {
            listaCarros.Add(item);
        }

        public void Buses(Buses item)
        {
            listaBus.Add(item);
        }

        public Carros mostrarCarros()
        {
            foreach (var item in listaCarros)
            {
                if(item is Carros)
                {
                    return (Carros)item;
                }
               
            }
            return null;
        }

        public Buses mostrarBus()
        {
            foreach (var item in listaBus)
            {
                if (item is Buses)
                {
                    return (Buses)item;
                }

            }
            return null;
        }

    }
}
