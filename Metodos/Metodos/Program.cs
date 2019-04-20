using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var Diccionario = new string[9];
            var Obj = new StreamReader("C:\\Users\\roche\\Desktop\\ProyectoE1\\KeyWords.txt");

            LLenarDiccionario(Obj);
            Console.ReadLine();
            Console.WriteLine("Escriba Lo que decea hacer.");
            Instert(Console.ReadLine());
            void Instert(string linea)
            {

            }

            //♪
             void LLenarDiccionario(StreamReader T)
            {
                int i = 0;
                var texto = T.ReadLine();
                while (texto != null)
                {
                    Diccionario[i] = texto;
                    texto = T.ReadLine();
                    i++;
                }
            }
        }
        
    }
}
