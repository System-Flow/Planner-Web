using System.Collections.Generic;

namespace PlannerWeb.Domain.Entities.KnowledgeWall
{
    public class KnowledgeWall : BaseEntity
    {

        public KnowledgeWall(List<string> listOfKnowledge)
        {
            ListOfKnowledge = listOfKnowledge;
        }

        public  List<string>  ListOfKnowledge { get; private set; }
        
    }
}