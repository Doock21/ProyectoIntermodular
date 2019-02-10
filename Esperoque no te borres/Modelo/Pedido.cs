using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Pedido
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public int comensales { get; set; }
        public int mesa { get; set; }
        public int empleado { get; set; }


        public Pedido() { }

        public Pedido(int id, string fecha, int comensales, int mesa, int empleado)
        {
            this.id = id;
            this.fecha = fecha;
            this.comensales = comensales;
            this.mesa = mesa;
            this.empleado = empleado;
        }
    }
}

