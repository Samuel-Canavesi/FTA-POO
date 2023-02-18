using Microsoft.EntityFrameworkCore;
using Livraria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Dados.Map
{
    public class TaskMap : IEntityTypeConfiguration<task>
    {
        public void Configure(EntityTypeBuilder<task> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.description).HasMaxLength(2048);
            builder.Property(x => x.status).IsRequired().HasMaxLength(50);

        }

    }
}