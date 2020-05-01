using System;

namespace Bludata.Teste.CSharp.Domain.Entities
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public bool Active { get; set; } = true;
        public DateTime Update_At { get; set; }

        public void Disable()
        {
            Active = false;
        }

        public void SetUpdateAt()
        {
            Update_At = DateTime.Now;
        }
    }
}
