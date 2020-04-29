namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class Contact : EntityBase
    {
        public string Number { get; protected set; }
        public int Provider_Id { get; protected set; }
        public Provider Provider { get; protected set; }
    }
}
