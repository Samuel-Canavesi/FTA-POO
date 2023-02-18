using Livraria.Dados.Enums;

namespace Livraria.Models
{
    public class task
    {
        public int id {get; set;}

        public string? name {get; set;}

        public string? description {get; set;}

        public statusTarefa status {get; set;}
    }
}