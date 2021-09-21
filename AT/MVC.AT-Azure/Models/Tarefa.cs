using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.AT_Azure.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string ToDo { get; set; } = "Tarefa";
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Quem { get; set; }
    }
}
