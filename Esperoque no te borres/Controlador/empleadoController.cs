using Esperoque_no_te_borres.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Controlador
{
    class empleadoController
    {
        
        public static void insertar(int codigo, string dni, string password, string nombre, string appellido,float sueldo, string rango)
        {
            Empleado empleado = new Empleado(codigo, dni, password, nombre, appellido,sueldo, rango);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/empleado", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(empleado);
            rest.Execute(request);
        }
        public static List<Empleado> obtener(string dni)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/empleado/{id}", Method.GET);
            request.AddUrlSegment("id", dni);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Empleado>>(response.Content);
        }
        public static List<Empleado> obtener()
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/empleado/", Method.GET);
            var response = rest.Execute(request);
            return JsonConvert.DeserializeObject<List<Empleado>>(response.Content);
        }
        public static void actualizar(int codigo, string dni, string password, string nombre, string appellido, float sueldo, string rango)
        {
            Empleado empleado = new Empleado(codigo, dni, password, nombre, appellido, sueldo, rango);
            var rest = new RestClient("http://localhost:1337");
            var request = new RestRequest("/empleado", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(empleado);
            rest.Execute(request);
        }
        public static void eliminar(string dni)
        {
            var rest = new RestClient("http://localhost:1337/");
            var request = new RestRequest("/empleado/{id}", Method.DELETE);
            request.AddUrlSegment("id", dni);
            rest.Execute(request);
        }
    }
}
