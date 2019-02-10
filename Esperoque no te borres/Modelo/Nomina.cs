using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Nomina
    {
        public int numero { get; set; }
        public float horas { get; set; }
        public float euros { get; set; }
        public int empleado { get; set; }

        public Nomina(int numero, float horas, float euros,int empleado)
        {
            this.numero = numero;
            this.horas = horas;
            this.euros = euros;
            this.empleado = empleado;
        }

        public Nomina() { }
    }
}

