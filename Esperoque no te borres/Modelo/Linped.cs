using Esperoque_no_te_borres.Controlador;
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
        public int producto { get; set; }
        public int pedido { get; set; }
        public string alaisP { get; set; }
        public float valorUNID { get; set; }





        public Linped() { }

        public Linped(int numero, int cantidad, int producto, int pedido)
        {
            List<Producto> aux = productoController.obtener(producto);
            this.numero = numero;
            this.cantidad = cantidad;
            this.importe = cantidad * aux[0].precio;
            this.producto = producto;
            this.pedido = pedido;
            this.alaisP = aux[0].nombre;
            this.valorUNID = aux[0].precio;
        }
        public Linped(int numero, int cantidad, float importe, int producto, int pedido)
        {
            List<Producto> aux = productoController.obtener(producto);
            this.numero = numero;
            this.cantidad = cantidad;
            this.importe = importe;
            this.producto = producto;
            this.pedido = pedido;
        }
    }
}
