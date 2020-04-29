using System;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class Company : EntityBase
    {
        public string CNPJ { get; protected set; }
        public string Fantasy { get; protected set; }
        public Guid State_Id { get; protected set; }
        public virtual State State { get; protected set; }
    }
}
