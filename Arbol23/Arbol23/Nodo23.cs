using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol23
{
    class Nodo23
    {
        public Nodo23 Padre;
        public Nodo23[] Hijos = new Nodo23[3];
        public Vehiculo[] Valores = new Vehiculo[2];
        public Nodo23()
        {
            Padre = null;
            Hijos[0] = null;
            Hijos[1] = null;
            Hijos[2] = null;
            Valores[0] = null;
            Valores[1] = null;
        }
    }
}
