using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Ticket
    {
        public int codigo { get; set; }
        public string fecha { get; set; }
        public float precio_total { get; set; }

        public float precio_comensal { get; set; }

        public Ticket() { }

        public Ticket(int codigo, string fecha, float precio_total, float precio_comensal)
        {
            this.codigo = codigo;
            this.fecha = fecha;
            this.precio_total = precio_total;
            this.precio_comensal = precio_comensal;
        }
    }
}
