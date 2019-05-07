using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolB
{
    class Program
    {
        static void Main(string[] args)
        {
           ArbolB Arbol = new ArbolB();


            string[] lineas = File.ReadAllLines("C:\\Users\\roche\\Desktop\\ProyectoE1\\CSVPrueba.csv");

            foreach (var linea in lineas)
            {
                Vehiculo Dato = new Vehiculo
                {
                    Id = int.Parse(linea)
                };
                Arbol.Insertar(Arbol.Raiz, Dato);
            }

            bool salir = false;
            while (salir == false)
            {
                Console.WriteLine("Ingrese numero a eliminar");
                Vehiculo buscar= new Vehiculo();
                  buscar.Id = int.Parse(Console.ReadLine());
                Arbol.Eliminar(buscar, Arbol.Raiz);
                Console.WriteLine("Desea seguir");
                int seguir = int.Parse(Console.ReadLine());
                if (seguir == 0)
                {
                    salir = true;
                }
            }
            Console.WriteLine("Busqueda");
            salir = false;
            while (salir == false)
            {
                Console.WriteLine("Ingrese numero a buscar");
                Vehiculo buscar = new Vehiculo();
                buscar.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Se encontro {0}", Arbol.Busqueda(buscar, Arbol.Raiz));
                Console.WriteLine("Desea seguir");
                int seguir = int.Parse(Console.ReadLine());
                if (seguir == 0) salir = true;
            }

            Console.ReadKey();

        }
    }
}
