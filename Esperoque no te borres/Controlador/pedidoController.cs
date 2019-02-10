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
    class pedidoController
    {
        public static void insertar(int id, string fecha, int comensales, int mesa, int empleado)
        {
            Pedido pedido = new Pedido(id, fecha, comensales, mesa, empleado);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/ticket", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(pedido);
            rest.Execute(request);
        }
        public static List<Pedido> obtener(int id)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/ticket/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Pedido>>(response.Content);
        }
        public static List<Pedido> obtener()
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/ticket/", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Pedido>>(response.Content);
        }
        public static void actualizar(int id, string fecha, int comensales, int mesa, int empleado)
        {
            Pedido pedido = new Pedido(id, fecha, comensales, mesa, empleado);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/ticket", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(pedido);
            rest.Execute(request);
        }
        public static void eliminar(int id)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/ticket/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            rest.Execute(request);
        }
    }
}
