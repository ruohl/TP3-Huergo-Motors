using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuegoVentas
{
    public class VentaItem
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int IdAccesorio { get; set; }
        public string Accesorio { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
