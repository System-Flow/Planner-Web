using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlannerWeb.Domain.Commands.Contracts;
using PlannerWeb.Domain.Commands.KnowledgeWallCommads;
using PlannerWeb.Domain.Entities.KnowledgeWall;
using PlannerWeb.Domain.Handlers;
using PlannerWeb.Domain.Repositories;

namespace PlannerWeb.Api.Controllers
{
    [ApiController]   
    [Route("v1/knowledgewalls")]
        
    public class KnowledgeWallController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<KnowledgeWall> GetAll(
            [FromServices]IKnowledgeWall repository
        )
        {
           return repository.GetAll();
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody]CreateCommandKnowledgeWall command,
            [FromServices]KnowledgeWallHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody]UpdateCommandKnowledgeWall command,
           [FromServices]KnowledgeWallHandler handler
       )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        
    }
}