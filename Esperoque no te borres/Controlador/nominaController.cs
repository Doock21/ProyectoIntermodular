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
    class nominaController
    {
        public static void insertar(int numero, float horas, float euros)
        {
            Nomina nomina = new Nomina(numero, horas, euros);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(nomina);
            rest.Execute(request);
        }
        public static List<Nomina> obtener(int numero)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.GET);
            request.AddUrlSegment("id", numero);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Nomina>>(response.Content);
        }
        public static List<Nomina> obtener( )
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Nomina>>(response.Content);
        }
        public static void actualizar(int numero, float horas, float euros)
        {
            Nomina nomina = new Nomina(numero, horas, euros);
            var rest = new RestClient("http://localhost:3000");
            var request = new RestRequest("/ticket", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(nomina);
            rest.Execute(request);
        }
        public static void eliminar(int numero)
        {
            var rest = new RestClient("http://localhost:3000/");
            var request = new RestRequest("/ticket/{id}", Method.DELETE);
            request.AddUrlSegment("id", numero);
            rest.Execute(request);
        }
    }
}
