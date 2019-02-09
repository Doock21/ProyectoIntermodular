using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Esperoque_no_te_borres.Modelo;
using RestSharp;

namespace Esperoque_no_te_borres.Controlador
{
    class productoController
    {
        public static void insertar(int codigo, string nombre, string especificaciones, float precio, int grupo)
        {
            Producto producto = new Producto(codigo, nombre, especificaciones, precio, grupo);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/producto", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(producto);
            rest.Execute(request);
        }
        public static List<Producto> obtener(int codigo)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/producto/{id}", Method.GET);
            request.AddUrlSegment("id", codigo);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Producto>>(response.Content);
        }
        public static List<Producto> obtener()
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/producto", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Producto>>(response.Content);
        }
        public static void actualizar(int codigo, string nombre, string especificaciones, float precio, int grupo)
        {
            Producto producto = new Producto(codigo, nombre, especificaciones, precio, grupo);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/producto", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(producto);
            rest.Execute(request);
        }
        public static void eliminar(int codigo)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/producto/{id}", Method.DELETE);
            request.AddUrlSegment("id", codigo);
            rest.Execute(request);
        }
    }
}
