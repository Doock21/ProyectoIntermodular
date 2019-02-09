using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Producto
    {
            public int codigo { get; set; }
            public string nombre { get; set; }
            public string especificaciones { get; set; }
            public float precio { get; set; }
        // public string imagen { get; set; }
        public int grupo { get; set; }




        public Producto() { }

            public Producto(int codigo, string nombre, string especificaciones, float precio, int grupo)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.especificaciones = especificaciones;
                this.precio = precio;
                this.grupo = grupo;
            }
        public Producto(int codigo, string nombre, string especificaciones, float precio, string imagen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.especificaciones = especificaciones;
            this.precio = precio;
            //this.imagen = imagen;
        }
    }
}
