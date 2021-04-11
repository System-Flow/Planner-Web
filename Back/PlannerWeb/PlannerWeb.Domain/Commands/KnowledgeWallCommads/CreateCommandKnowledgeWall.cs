using System;
using System.Collections.Generic;
using PlannerWeb.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System.Linq;

namespace PlannerWeb.Domain.Commands.KnowledgeWallCommads
{
    public class CreateCommandKnowledgeWall : ICommand
    {
       public CreateCommandKnowledgeWall()
       {
           ListOfKnowledgeWall =  new List<string>();
       }

        public CreateCommandKnowledgeWall(List<string> listOfKnowledgeWall )
        {
            ListOfKnowledgeWall = listOfKnowledgeWall;
        }
        public List<string> ListOfKnowledgeWall { get; set; }

        public void Validate()
        {
            
            
        }
    }
}