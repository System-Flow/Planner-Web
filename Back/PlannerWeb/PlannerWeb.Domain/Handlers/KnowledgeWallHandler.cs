using System.Linq;
using PlannerWeb.Domain.Commands.Contracts;
using PlannerWeb.Domain.Commands.KnowledgeWallCommads;
using PlannerWeb.Domain.Entities.KnowledgeWall;
using PlannerWeb.Domain.Handlers.Contracts;
using PlannerWeb.Domain.Repositories;

namespace PlannerWeb.Domain.Handlers
{
    public class KnowledgeWallHandler :
        IHandler<CreateCommandKnowledgeWall>,
        IHandler<UpdateCommandKnowledgeWall>
    {
        private readonly IKnowledgeWall _repository;

        public KnowledgeWallHandler(IKnowledgeWall repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateCommandKnowledgeWall command)
        {
            
            var knowledgeWall = new KnowledgeWall(command.ListOfKnowledgeWall);

            // Salva no banco
            _repository.Create(knowledgeWall);

            // Retorna o resultado
            return new GenericCommandResult(true, "KnowledgeWall salvo", knowledgeWall);
        }

        public ICommandResult Handle(UpdateCommandKnowledgeWall command)
        {
          
            var knowledgeWallDB = _repository.GetById(command.Id);

        
            // Salva no banco
            _repository.Update(knowledgeWallDB);

            // Retorna o resultado
            return new GenericCommandResult(true, "Tarefa salva", knowledgeWallDB);
        }

     
    }
}