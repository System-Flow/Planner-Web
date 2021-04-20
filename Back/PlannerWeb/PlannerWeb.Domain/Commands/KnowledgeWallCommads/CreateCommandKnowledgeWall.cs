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
            TextKnowledgeWall =  string.Empty;
       }

        public CreateCommandKnowledgeWall(string textKnowledgeWall)
        {
            TextKnowledgeWall = textKnowledgeWall;
        }
        public string TextKnowledgeWall { get; set; }

        public void Validate()
        {
            
            
        }
    }
}