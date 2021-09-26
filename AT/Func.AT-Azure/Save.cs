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
    public static class Save
    {
        [FunctionName("Save")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            Tarefa data = JsonConvert.DeserializeObject<Tarefa>(requestBody);

            data.Id = Guid.NewGuid();

            RepositoryDB db = new RepositoryDB();

            if (data == null)
                return new BadRequestObjectResult(new { message = "É necessário que você adicione os dados da tarefa no corpo do JSON!" });

            await db.Save(data);
            

            return new OkObjectResult(data);
        }
    }
}
