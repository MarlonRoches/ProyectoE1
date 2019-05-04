using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolB
{
    public class Vehiculo : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
