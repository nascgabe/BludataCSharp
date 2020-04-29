using System;
using System.Collections.Generic;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class Provider : EntityBase
    {        
        public string Name { get; protected set; }
        public DateTime Create_At { get; protected set; }
        public string CPF { get; protected set; }
        public string CNPJ { get; protected set; }
        public Company Company { get; protected set; }
        public PersonType Physical_Person { get; protected set; }
        public ICollection<Contact> Phone { get; protected set; }
    }
}
