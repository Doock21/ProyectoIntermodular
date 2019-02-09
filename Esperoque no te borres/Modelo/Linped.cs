using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Linped
    {
        public int numero { get; set; }
        public int cantidad { get; set; }
        public float importe { get; set; }

        public Linped() { }

        public Linped(int numero, int cantidad, float importe)
        {
            this.numero = numero;
            this.cantidad = cantidad;
            this.importe = importe;
        }
    }
}
