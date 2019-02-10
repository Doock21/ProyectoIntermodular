using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using RestSharp;
using Esperoque_no_te_borres.Modelo;

namespace Esperoque_no_te_borres.Controlador
{
    class linpedController
    {
        public static void insertar(int numero, int cantidad, float importre, int producto, int pedido)
        {
            Linped linped = new Linped(numero, cantidad, importre, producto,pedido);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(linped);
            rest.Execute(request);
        }
        public static List<Linped> obtener(int numero)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/lineaPedido/{id}", Method.GET);
            request.AddUrlSegment("id", numero);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Linped>>(response.Content);
        }
        public static List<Linped> obtener()
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/lineaPedido/", Method.GET);          
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Linped>>(response.Content);
        }
        public static void actualizar(int numero, int cantidad, float importre, int producto, int pedido)
        {
            Linped linped = new Linped(numero, cantidad, importre, producto, pedido);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/lineaPedido", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(linped);
            rest.Execute(request);
        }
        public static void eliminar(int numero)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/lineaPedido/{id}", Method.DELETE);
            request.AddUrlSegment("id", numero);
            rest.Execute(request);
        }
    }
}
