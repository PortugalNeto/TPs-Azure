using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace Infra
{
    public class Tarefa
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "pk")]
        public string ToDo { get; set; } = "Tarefa";


        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Quem { get; set; }

    }
}
