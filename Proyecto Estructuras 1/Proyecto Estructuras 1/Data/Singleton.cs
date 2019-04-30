using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Proyecto_Estructuras_1.Models;
using System.Web.Mvc;

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
        
        public void ArchivoPredeterminado()
        {
            string Origen = "~/ProyectoE1/";
            CustomSplit(Origen);
        }
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
        /// <summary>
        /// <param enviada del controlador ="operacion"></param>
        /// 
        /// </summary>
        public void split_linea(string operacion)
        {
            string captura = operacion;
            string[] arreglo = captura.Split(' ');
            string[] arreglo2 = captura.Split('\n');
            string CompletarInstruccion = arreglo[1];
            foreach (var item in arreglo)
            {
                switch (item)
                {
                    case "Select":                        
                        palabra(CompletarInstruccion);
                        break;
                    case "From":
                        break;
                    case "Delete":
                        break;
                    case "Where":
                        break;
                    case "Create_Table":
                        break;
                    case "Drop_Table":
                        break;
                    case "Insert_Into":
                        break;
                    case "Value":
                        break;
                    case "Go":
                        break;

                }
            }
        }
        public string palabra(string P)
        {
            string Thor = P;
            return Thor;
        }
        public void Palabras_Reservadas()
        {
            PalabrasReservadas[0] = "Select";
            PalabrasReservadas[1] = "From";
            PalabrasReservadas[2] = "Delete";
            PalabrasReservadas[3] = "Where";
            PalabrasReservadas[4] = "Create_Table";
            PalabrasReservadas[5] = "Drop_Table";
            PalabrasReservadas[6] = "Insert_Into";
            PalabrasReservadas[7] = "Value";
            PalabrasReservadas[8] = "Go";
        }
        //guardar arbol


        }
}