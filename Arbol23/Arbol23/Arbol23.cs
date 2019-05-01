using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol23
{
    class Arbol23
    {
        public Nodo23 Raiz = new Nodo23();
        /// <summary>
        /// Devuelve un bool el cual indica si es padre o no
        /// </summary>
        /// <param name="actual">Nodo actual</param>
        /// <returns></returns>
        public bool EsPadre(Nodo23 actual)
        {
            if (actual.Hijos[0]==null && actual.Hijos[1]==null && actual.Hijos[2]==null )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Devuelve un booleano para saber si esta lleno o no
        /// </summary>
        /// <param name="actual"></param>
        /// <returns></returns>
        public bool EstaLleno(Nodo23 actual)
        {
            if (actual.Valores[0]==null && actual.Valores[1] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void InsertarEn(Nodo23 Actual, Vehiculo Nuevo)
        {
            if (EsPadre(Actual)==false)
            {
                if (Actual.Valores[0]==null)
                {
                    Actual.Valores[0] = Nuevo;
                }
                else 
                {
                    if (Actual.Valores[1] == null)
                    {
                    Actual.Valores[1] = Nuevo;
                    }
                    else
                    {
                        Separar(Actual, Nuevo);
                        // else lleno, separar
                    }
                }

            }
        }

        public void Ordenar(Nodo23 Actual)
        {
            //OrdenarVECTOR
        }
        public Nodo23 Navegar (Nodo23 Actual , Vehiculo Nuevo)
        {
            if (EstaLleno(Actual) ==false)
            {

                return Actual;
            }
            else
            {
                if (Nuevo.Id < Actual.Valores[0].Id)
                {
                    Navegar(Actual.Hijos[0], Nuevo);
                }
                if (Nuevo.Id > Actual.Valores[0].Id && Nuevo.Id < Actual.Valores[1].Id)
                {

                    Navegar(Actual.Hijos[1], Nuevo);
                }
                if (Nuevo.Id > Actual.Valores[1].Id)
                {

                    Navegar(Actual.Hijos[2], Nuevo);
                }
                return Actual;
            }
        }
        public void Separar(Nodo23 actual, Vehiculo nuevo)
        {
            if (EsPadre(actual))
            {
                //aqui se separaria la raiz
            }
            else
            {
                Vehiculo[] Aux = new Vehiculo[3];
                Nodo23 Hijo1 = new Nodo23();
                Nodo23 Hijo2 = new Nodo23();
                Nodo23 NuevaRAiz = new Nodo23();
                actual.Valores[0] = Aux[0];
                actual.Valores[1] = Aux[1];
                nuevo = Aux[2];
                // ORDENBAR AUX

                NuevaRAiz.Valores[0] = Aux[0];
                Hijo1.Valores[0] = Aux[1];
                Hijo2.Valores[0] = Aux[2];
                Raiz = null;
                NuevaRAiz.Hijos[0] = Hijo1;
                NuevaRAiz.Hijos[1] = Hijo2;
                Hijo1.Padre = Raiz;
                Hijo2.Padre = Raiz;
                Raiz = NuevaRAiz;
                
            }
        }
    }
}
