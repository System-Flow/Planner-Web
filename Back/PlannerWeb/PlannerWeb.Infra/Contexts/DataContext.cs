using Microsoft.EntityFrameworkCore;
using PlannerWeb.Domain.Entities.KnowledgeWall;

namespace PlannerWeb.Infra.Context 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<KnowledgeWall> KnowledgeWalls { get; set; }

        //DEPOIS DE TODO O SQUEMA DO BANCO FETIO REALIZAR A MANUPILAÇÃO PELO ONMODELCREATING
    }
}