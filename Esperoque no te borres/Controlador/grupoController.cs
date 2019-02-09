using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esperoque_no_te_borres.Modelo;


namespace Esperoque_no_te_borres.Controlador
{
    class grupoController
    {
        public static void insertar(int id, string nombre, string descripcion)
        {
            Grupo Grupo = new Grupo(id, nombre, descripcion);
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(Grupo);
            rest.Execute(request);
        }
        public static List<Grupo> obtener(int id)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/grupo/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Grupo>>(response.Content);
        }
        public static List<Grupo> obtener()
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/grupo", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Grupo>>(response.Content);
        }
        public static void actualizar(int id, string nombre, string descripcion)
        {
            Grupo Grupo = new Grupo(id, nombre, descripcion);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/grupo", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(Grupo);
            rest.Execute(request);
        }
        public static void eliminar(int id)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/grupo/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            rest.Execute(request);
        }
    }
}
