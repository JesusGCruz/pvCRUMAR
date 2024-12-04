using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCRUMAR
{
    public class DetalleVenta
    {

        public int idProductoVenta { get; set; }

        public int idVenta { get; set; }
        public int codigoBarras { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
        public decimal subtotal { get; set; }

    }
}
