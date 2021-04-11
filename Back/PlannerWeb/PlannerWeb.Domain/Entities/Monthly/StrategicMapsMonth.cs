using System;
using System.Collections.Generic;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class StrategicMapsMonth : BaseEntity
    {
        public StrategicMapsMonth(MenstrualCalendar menstrualCalendar, Week myWeek, List<Notes> listOfNotes)
        {
            MenstrualCalendar = menstrualCalendar;
            MyWeek = myWeek;
            ListOfNotes = listOfNotes;
        }

        public MenstrualCalendar MenstrualCalendar { get; private set; }
        public Week MyWeek { get; private set; }
        public List<Notes> ListOfNotes { get; private set; }
    }
}