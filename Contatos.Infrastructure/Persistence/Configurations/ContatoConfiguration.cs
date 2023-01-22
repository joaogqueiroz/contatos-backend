using Contatos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contatos.Infrastructure.Persistence.Configurations
{
    public class ContatoConfiguration: IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder
            .HasOne(a => a.Pessoa)
            .WithMany(o => o.Contatos)
            .HasForeignKey(a => a.PessoaId);
        }
    }
}