using Microsoft.EntityFrameworkCore;
using Livraria.Models;
using Livraria.Dados.Map;
using System.Data;

namespace Livraria.Dados
{
    public class TarefasDB : DbContext
    {
        public TarefasDB(DbContextOptions<TarefasDB> options)
            : base(options)
        {

        }
        
        public DbSet<usermodel> Usuarios {get; set;}
        public DbSet<task> Tarefas {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }
    
    }
    
}