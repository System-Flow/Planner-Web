using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlannerWeb.Domain.Entities.KnowledgeWall
{   
    
    public class KnowledgeWall : BaseEntity
    {
        public KnowledgeWall(Guid idUser, string textKnowledgeWall)
        {
            IdUser = idUser;
            TextKnowledgeWall = textKnowledgeWall;
        }

        public Guid IdUser { get; private set; }
        public string TextKnowledgeWall { get; private set; }
        
    }
}