using System.ComponentModel;
namespace Livraria.Dados.Enums
{
    public enum statusTarefa
    {
        [Description("Precisa fazer")]
        A_fazer =1,
        
        [Description("Esta fazendo")]
        Andamento = 2,

        [Description("Finalizado")]
        Concluido = 3
    }
}