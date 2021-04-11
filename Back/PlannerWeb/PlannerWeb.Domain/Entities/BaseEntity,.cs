using System;

namespace PlannerWeb.Domain.Entities
{
    public abstract class BaseEntity: IEquatable<BaseEntity> 
    {

        public Guid Id { get; private set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }
    }
}