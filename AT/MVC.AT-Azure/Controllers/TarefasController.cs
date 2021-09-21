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
        public IActionResult Cadastrar(string nome, string descricao, string status, string quem)
        {


            return Redirect("/tarefas/index");
        }


    }
}
