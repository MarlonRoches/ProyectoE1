using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Estructuras_1.Models
{
    public class Vehiculo
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Linea { get; set; }
        DateTime SalidaAlMercado { get; set; }
        int CaballosDeFuerza { get; set; }
    }
}