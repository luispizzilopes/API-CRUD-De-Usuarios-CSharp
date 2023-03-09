using ApiDeTarefas.Enums;
using System.Reflection;

namespace ApiDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome {  get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
