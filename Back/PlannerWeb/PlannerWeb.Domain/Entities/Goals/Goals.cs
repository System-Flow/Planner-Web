using System;

namespace PlannerWeb.Domain.Entities.Goals
{
    public class Goals : BaseEntity
    {
        public Goals(string name, DateTime deadline, decimal cost)
        {
            Name = name;
            Deadline = deadline;
            Cost = cost;
        }

        public string Name { get ;  private set ; }
        public DateTime Deadline { get ; private set; }
        public decimal Cost { get ; private set; }

    }
}