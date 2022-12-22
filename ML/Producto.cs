using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public int Sku { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public ML.Marca Marca { get; set; }
        public bool ProductoMostrarEnElHome { get; set; }
        public List<object> Productos { get; set; }

    }
}
