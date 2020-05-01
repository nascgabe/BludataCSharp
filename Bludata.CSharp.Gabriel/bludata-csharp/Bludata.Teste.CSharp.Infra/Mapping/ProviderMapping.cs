using Bludata.Teste.CSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bludata.Teste.CSharp.Infra.Mapping
{
    public class ProviderMapping : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.Property(d => d.Name).HasColumnName(nameof(Provider.Name));
            builder.Property(d => d.Create_At).HasColumnName(nameof(Provider.Create_At)).IsRequired();
            builder.Property(d => d.ContactNumber).HasColumnName(nameof(Provider.ContactNumber)).IsRequired();
            builder.Property(d => d.CPF).HasColumnName(nameof(Provider.CPF));
            builder.Property(d => d.RG).HasColumnName(nameof(Provider.RG));
            builder.Property(d => d.PersonType).HasColumnName(nameof(Provider.PersonType)).IsRequired();
            builder.Property(d => d.CNPJProvider).HasColumnName(nameof(Provider.CNPJProvider)).IsRequired();

            builder.HasOne(d => d.Company).WithMany().HasForeignKey(d => d.Id).IsRequired();
        }
    }
}
