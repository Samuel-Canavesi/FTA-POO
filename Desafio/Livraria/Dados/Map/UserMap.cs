using Microsoft.EntityFrameworkCore;
using Livraria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Dados.Map
{
    public class UserMap : IEntityTypeConfiguration<usermodel>
    {
        public void Configure(EntityTypeBuilder<usermodel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.email).IsRequired().HasMaxLength(255);

        }
    }
}