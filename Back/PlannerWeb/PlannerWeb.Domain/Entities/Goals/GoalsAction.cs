namespace PlannerWeb.Domain.Entities.Goals
{
    public class GoalsAction : BaseEntity
    {
        public GoalsAction(string nameAction, int frequency, decimal costPerAction)
        {
            NameAction = nameAction;
            Frequency = frequency;
            CostPerAction = costPerAction;
        }

        public string NameAction { get; private set; }
        public int Frequency { get; private set; }
        public decimal CostPerAction { get; private set; }
    }
}