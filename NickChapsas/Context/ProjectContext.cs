using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace NickChapsas
{
    public class ProjectContext : DbContext
    {
        protected ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions options) : base(options)
        {
        }
    }
}