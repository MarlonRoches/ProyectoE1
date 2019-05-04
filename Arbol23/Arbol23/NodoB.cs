using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolB
{
    public class NodoB: IComparable
    {
        public NodoB Padre { get; set; }
        public List<NodoB> Nodos { get; set; }
        public List <Vehiculo>Datos { get; set; }
        public int Id { get; set; }
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public NodoB()
        {
            Padre = null;
            Nodos = new List<NodoB>();
            Datos = new List<Vehiculo>();
            Id = 0;
            Maximo = 0;
            Minimo = 0;
        }
        
        public void AsignarGrado(NodoB Nodo, int grado)
        {
            Nodo.Maximo = grado - 1;
            Nodo.Minimo = Nodo.Maximo / 2;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
