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
        public LinkedList<Vehiculo> ListaVehiculos = new LinkedList<Vehiculo>();

        public string[] PalabrasReservadas = new string[9];

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
        public void Palabras_Reservadas()
        {
            PalabrasReservadas[0] = "Select";
            PalabrasReservadas[1] = "From";
            PalabrasReservadas[2] = "Delete";
            PalabrasReservadas[3] = "Where";
            PalabrasReservadas[4] = "Create Table";
            PalabrasReservadas[5] = "Drop Table";
            PalabrasReservadas[6] = "Insert Into";
            PalabrasReservadas[7] = "Value";
            PalabrasReservadas[8] = "Go";
        }
        //guardar arbol


        }
}