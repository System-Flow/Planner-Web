using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerWeb.Domain.Entities
{
    public abstract class BaseEntity: IEquatable<BaseEntity> 
    {
        [Key]
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