using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Promocion
    {
        public int IdPromocion { get; set; }
        public string NombrePromocion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public List<object> Promociones { get; set; }
    }
}
