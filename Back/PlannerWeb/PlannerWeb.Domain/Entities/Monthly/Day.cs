using System;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class Day : BaseEntity
    {
        public Day(DayOfWeek dayOfWeek)
        {
            DayOfWeek = dayOfWeek;
        }

        public DayOfWeek DayOfWeek { get; private set; }
    }
}