using Bludata.Teste.CSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bludata.Teste.CSharp.Infra.Mapping
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(d => d.CNPJ).HasColumnName(nameof(Company.CNPJ));
            builder.Property(d => d.Fantasy).HasColumnName(nameof(Company.Fantasy)).IsRequired();
            builder.Property(d => d.StateId).HasColumnName(nameof(Company.StateId)).IsRequired();
        }
    }
}
