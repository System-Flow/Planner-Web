using System.Collections.Generic;
using System;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class Week : BaseEntity
    {
        public Week()
        {
            Days = new List<Day>(){new Day(DayOfWeek.Sunday),
                                   new Day(DayOfWeek.Monday),
                                   new Day(DayOfWeek.Tuesday),
                                   new Day(DayOfWeek.Wednesday),
                                   new Day(DayOfWeek.Thursday),
                                   new Day(DayOfWeek.Friday),
                                   new Day(DayOfWeek.Saturday)};
        }
        public List<Day> Days { get; private set; }

    }

}