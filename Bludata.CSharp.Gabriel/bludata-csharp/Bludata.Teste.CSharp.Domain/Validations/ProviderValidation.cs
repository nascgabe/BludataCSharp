using Bludata.Teste.CSharp.Domain.Entities;
using FluentValidation;

namespace Bludata.Teste.CSharp.Domain.Validations
{
    public class ProviderValidation : AbstractValidator<Provider>
    {
        public ProviderValidation()
        {
            RuleFor(x => x.Company.State.UF)
                .Equal("PR")
                .WithMessage("Necessário ser maior de 18 anos.");

        }
    }
}
