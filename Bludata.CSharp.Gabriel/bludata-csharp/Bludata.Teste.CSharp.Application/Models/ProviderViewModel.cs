using Bludata.Teste.CSharp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Bludata.Teste.CSharp.Application.Models
{
    public class ProviderViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Create_At { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public Guid Company_Id { get; set; }
        public virtual Company Company { get; set; }
        public ICollection<PhoneViewModel> Phone { get; set; }
    }
}
