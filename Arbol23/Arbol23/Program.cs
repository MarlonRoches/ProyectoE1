using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol23
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol23 Arbol = new Arbol23();
            Vehiculo Carro1 = new Vehiculo();
            Vehiculo Carro2 = new Vehiculo();
            Vehiculo Carro3 = new Vehiculo();
            Arbol.InsertarEn(Arbol.Raiz, Carro1);
            Arbol.InsertarEn(Arbol.Raiz, Carro2);
            Arbol.InsertarEn(Arbol.Raiz, Carro3);
        }
    }
}
