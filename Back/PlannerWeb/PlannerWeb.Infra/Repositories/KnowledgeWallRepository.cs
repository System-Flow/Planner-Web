using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PlannerWeb.Domain.Entities.KnowledgeWall;
using PlannerWeb.Domain.Repositories;
using PlannerWeb.Infra.Context;

namespace PlannerWeb.Infra.Repositories
{
    public class KnowledgeWallRepository : IKnowledgeWall
    {
        private readonly DataContext _context;

        public KnowledgeWallRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(KnowledgeWall Object)
        {
           this._context.KnowledgeWalls.Add(Object);
           this._context.SaveChanges();
        }

        public IEnumerable<KnowledgeWall> GetAll() => this._context.KnowledgeWalls.ToList(); 
       
        public KnowledgeWall GetById(Guid id)
        {
           var KnowledgeWall = this._context.KnowledgeWalls.FirstOrDefault(x => x.Id == id);
           return KnowledgeWall;
        }

        public void Update(KnowledgeWall Object)
        {
            this._context.Entry(Object).State = EntityState.Modified;
            this._context.SaveChanges();
        }
    }   
}