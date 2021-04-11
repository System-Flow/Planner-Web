using System;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class MenstrualCalendar : BaseEntity
    {
        public MenstrualCalendar(DateTime menstrualsDate)
        {
            MenstrualsDate = menstrualsDate;
        }

        public DateTime MenstrualsDate { get; private set; }

        public void ChangeMenstrualsDate(DateTime menstrualsDate) => MenstrualsDate = menstrualsDate;
    }
}