using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Proyecto_Estructuras_1.Models
{
    public class Vehiculo : IComparable
    {
        [DisplayName("No. Citas")]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public DateTime SalidaAlMercado { get; set; }
        public int CaballosDeFuerza { get; set; }
        public int CompareTo(object obj)
        {
            var comparable = (Vehiculo)obj;
            return Id.CompareTo(comparable.Id);
        }
    }
}