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
    class mesaController
    {

        public static void insertar(int id, int zona, int n_sillas)
        {
            Mesa mesa = new Mesa(id, zona, n_sillas);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(mesa);
            rest.Execute(request);
        }
        public static List<Mesa> obtener(int id)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Mesa>>(response.Content);
        }
        public static List<Mesa> obtener()
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Mesa>>(response.Content);
        }
        public static void actualizar(int id, int zona, int n_sillas)
        {
            Mesa mesa = new Mesa(id, zona, n_sillas);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(mesa);
            rest.Execute(request);
        }
        public static void eliminar(int id)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            rest.Execute(request);
        }
    }
}
