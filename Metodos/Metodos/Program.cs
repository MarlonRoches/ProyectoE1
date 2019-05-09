using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tipo = typeof(Vehiculo);
            FieldInfo[] Variables = tipo.GetFields();
            foreach (var variable in Variables)
            {
                string nombre = variable.Name;
                object temp = variable.GetValue(null);

            }
        }
        class Vehiculo
            {
             public int Valor;
            }
    }
}
