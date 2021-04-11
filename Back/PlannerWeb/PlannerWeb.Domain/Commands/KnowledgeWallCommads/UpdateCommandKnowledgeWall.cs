using System;
using System.Collections.Generic;
using PlannerWeb.Domain.Commands.Contracts;

namespace PlannerWeb.Domain.Commands.KnowledgeWallCommads
{
    public class UpdateCommandKnowledgeWall : ICommand
    {
        public UpdateCommandKnowledgeWall()
        {

        }

        public UpdateCommandKnowledgeWall(Guid id, string item)
        {
            Id = id;
            Item = item;
        }

        public Guid Id { get; set; }
        public string Item { get; set; }

        public void Validate()
        {
            
        }
    }
}