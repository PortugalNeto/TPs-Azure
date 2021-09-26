using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Infra;

namespace Func.AT_Azure
{
    public static class GetById
    {
        [FunctionName("GetById")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var id = req.Query["id"];

            RepositoryDB db = new RepositoryDB();

            Tarefa tar = db.GetById(id);

            if (tar == null)
                return new NotFoundObjectResult(new { message = "Tarefa não encontrada =(" });

            return new OkObjectResult(tar);
        }
    }
}
