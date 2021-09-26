using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using MVC.AT_Azure.Models;
using RestSharp.Serialization.Json;

namespace MVC.AT_Azure.Controllers
{
    public class TarefasController : Controller
    {

        public readonly string url = "https://atazureinfnet.azurewebsites.net/api/";

        [HttpGet]
        public IActionResult Index()
        {
            var client = new RestClient(url);
            
            var request = new RestRequest("GetAll", Method.GET);
            
            IRestResponse<List<Tarefa>> tar = client.Execute<List<Tarefa>>(request);
            
            var tarefas = tar.Data;
            ViewBag.ListTarefas = tarefas;
            
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Tarefa tarefa)
        {
            var client = new RestClient(url);
            
            var request = new RestRequest("Save", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(tarefa);
            client.Post(request);
            return Redirect("/tarefas/index");
        }

        [HttpGet]
        public ActionResult Detalhes(Guid id)
        {
            var client = new RestClient(url);

            var request = new RestRequest($"GetById?id={id}", Method.GET);

            var result = client.Execute<Tarefa>(request).Data;
            ViewBag.Tarefa = result;
            return View();
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            var client = new RestClient(url);

            var request = new RestRequest($"GetById?id={id}", Method.GET);

            var tarefa = client.Execute<Tarefa>(request).Data;
            ViewBag.Tarefa = tarefa;
            return View();
        }

        [HttpPost]
        public ActionResult Editar(Guid id, Tarefa tarefa)
        {
            var client = new RestClient(url);

            var request = new RestRequest("Update", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(tarefa);
            client.Put<Tarefa>(request);
            return Redirect("/tarefas/index");
        }

        [HttpGet]
        public IActionResult Excluir(Guid id)
        {
            var client = new RestClient(url);

            var request = new RestRequest($"GetById?id={id}", Method.GET);

            var result = client.Execute<Tarefa>(request).Data;

            ViewBag.Tarefa = result;
            
            return View();
        }

        [HttpPost]
        public ActionResult ConfirmaExclusao(Guid id)
        {
            var client = new RestClient(url);

            var request = new RestRequest($"Delete?id={id}", Method.DELETE);
            client.Execute(request);
            return Redirect("/tarefas/index");
        }
    }
}
