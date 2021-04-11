using System.Collections.Generic;

namespace PlannerWeb.Domain.Entities.Monthly
{
    public class Habits : BaseEntity
    {
        public Habits(string name, List<bool> stateHabits)
        {
            Name = name;
            StateHabits = stateHabits;
        }
        
        public string Name { get; private set; }
        public List<bool> StateHabits { get; private set; }
        public void AddStateIntoList(bool Value) => StateHabits.Add(Value);
        
    }
}