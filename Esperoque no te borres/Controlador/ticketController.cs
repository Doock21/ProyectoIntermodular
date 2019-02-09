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
    class ticketController
    {

        public static void insertar(int codigo, string fecha, float precio_total, float precio_comensal)
        {
            Ticket ticket = new Ticket(codigo, fecha, precio_total, precio_comensal);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(ticket);
            rest.Execute(request);
        }
        public static List<Ticket> obtener(int codigo)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.GET);
            request.AddUrlSegment("id", codigo);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Ticket>>(response.Content);
        }
        public static List<Ticket> obtener()
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Ticket>>(response.Content);
        }
        public static void actualizar(int codigo, string fecha, float precio_total, float precio_comensal)
        {
            Ticket ticket = new Ticket(codigo, fecha, precio_total, precio_comensal);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(ticket);
            rest.Execute(request);
        }
        public static void eliminar(int codigo)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.DELETE);
            request.AddUrlSegment("id", codigo);
            rest.Execute(request);
        }
    }
}
