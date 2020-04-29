using System;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class PersonType : EntityBase
    {
        public string CPF { get; protected set; }
        public string RG { get; protected set; }
        public DateTime Date_Birth { get; protected set; }
    }
}
