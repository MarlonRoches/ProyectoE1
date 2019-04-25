using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Proyecto_Estructuras_1.Models;

namespace Proyecto_Estructuras_1.Data
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }
        public Dictionary<string, string> Diccionario = new Dictionary<string, string>();
        public bool Ini = true;
        //lectura de archivo
        internal void CustomSplit(string direccion)
        {
            bool flag = true;
            if (flag)
            {
                StreamReader objReader = new StreamReader(direccion);
                string leerlineas = objReader.ReadLine();
                while (leerlineas != null)
                {
                    string[] datos = new string[2];
                    Palabras_Reservadas objeto = new Palabras_Reservadas();
                    datos = leerlineas.Split(',');
                    leerlineas = objReader.ReadLine();
                    objeto.llave = datos[0];
                    objeto.valor = datos[1];                                                        
                    string Key = objeto.llave;
                    Diccionario.Add(Key, objeto.valor);
                }
                flag = false;
                objReader.Close();
            }
        }
            //guardar arbol


        }
}