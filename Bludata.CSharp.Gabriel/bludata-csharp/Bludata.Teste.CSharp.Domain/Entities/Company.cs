using Bludata.Teste.CSharp.Domain.Enum;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class Company : EntityBase
    {
        public Company(string cNPJ, string fantasy, State stateId)
        {
            CNPJ = cNPJ;
            Fantasy = fantasy;
            StateId = stateId;
        }

        public string CNPJ { get; set; }
        public string Fantasy { get; set; }
        public virtual State StateId { get; set; }

        public void Update(string cNPJ, string fantasy, State stateId)
        {
            CNPJ = cNPJ;
            Fantasy = fantasy;
            StateId = stateId;
        }
    }
}
