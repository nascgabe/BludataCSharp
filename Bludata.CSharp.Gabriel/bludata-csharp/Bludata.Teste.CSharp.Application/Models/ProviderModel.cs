using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Enum;
using System;

namespace Bludata.Teste.CSharp.Application.Models
{
    public class ProviderModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime DateBirth { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public Guid CompanyId { get; set; }
        public string CNPJProvider { get; set; }
        public virtual State State { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual Company Company { get; set; }
        public string ContactNumber { get; set; }
    }
}
