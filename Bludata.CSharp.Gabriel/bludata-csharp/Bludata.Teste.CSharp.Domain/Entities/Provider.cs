using Bludata.Teste.CSharp.Domain.Enum;
using System;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class Provider : EntityBase
    {
        public Provider(string name, DateTime create_At, string cPF, string rG, DateTime dateBirth, string cNPJProvider, State state, PersonType personType, string contactNumber)
        {
            Name = name;
            Create_At = create_At;
            CPF = cPF;
            RG = rG;
            DateBirth = dateBirth;
            CNPJProvider = cNPJProvider;
            State = state;
            PersonType = personType;
            ContactNumber = contactNumber;
        }

        public string Name { get; set; }
        public DateTime Create_At { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DateBirth { get; set; }
        public Guid CompanyId { get; set; }
        public string CNPJProvider { get; set; }
        public virtual Company Company { get; set; }
        public virtual State State { get; set; }
        public virtual PersonType PersonType { get; set; }
        public string ContactNumber { get; set; }

        public void Update(string name, DateTime create_At, string cPF, string rG, DateTime dateBirth, string cNPJProvider, State state, PersonType personType, string contactNumber)
        {
            Name = name;
            Create_At = create_At;
            CPF = cPF;
            RG = rG;
            DateBirth = dateBirth;
            CNPJProvider = cNPJProvider;
            State = state;
            PersonType = personType;
            ContactNumber = contactNumber;
        }
    }
}
