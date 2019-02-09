using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Grupo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Grupo(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Grupo()
        {
        }
    }
}
