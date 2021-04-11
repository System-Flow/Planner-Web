
using System.Collections.Generic;

namespace PlannerWeb.Domain.Entities.Goals
{
    public class SuperGoals : BaseEntity 
    {
        public SuperGoals(Goals goals, List<GoalsAction> listActions)
        {
            Goals = goals;
            ListActions = listActions;
        }

        public Goals Goals { get; private set; }
        public  List<GoalsAction> ListActions { get; private set; }
    }
}