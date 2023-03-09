using System.ComponentModel;

namespace ApiDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazeer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3
    }
}
