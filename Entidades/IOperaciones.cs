using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public interface IOperaciones
    {
        void Insertar(int i);
        void Eliminar(int i);
        void Modificar(int id);

        int Buscar(int i);
    }
}
