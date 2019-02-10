using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Empleado
    {
        public int codigo { get; set; }
        public string dni { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public float sueldo { get; set; }

        public string rango { get; set; }

        public Empleado() { }

        public Empleado(int codigo, string dni, string password, string nombre, string apellidos, float sueldo, string rango)
        {
            this.codigo = codigo;
            this.dni = dni;
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sueldo = sueldo;
            this.rango = rango;
        }
    }
}
