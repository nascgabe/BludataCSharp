using Bludata.Teste.CSharp.Domain.Enum;

namespace Bludata.Teste.CSharp.Application.Models
{
    public class CompanyModel
    {
        public string CNPJ { get; set; }
        public string Fantasy { get; set; }
        public virtual State StateId { get; set; }
    }
}
