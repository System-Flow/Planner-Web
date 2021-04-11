using System.Collections.Generic;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class MonthlyHabitControl : BaseEntity
    {
        public MonthlyHabitControl(List<Habits> listOfHabits)
        {
            ListOfHabits = listOfHabits;
        }

        public List<Habits> ListOfHabits { get; private set; }

        public void SetNewHabit(Habits habit) => ListOfHabits.Add(habit);
    }
}