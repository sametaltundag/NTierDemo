using Microsoft.EntityFrameworkCore;
using Smt.TodoAppNTier.DataAccess.Configurations;
using Smt.TodoAppNTier.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.DataAccess.Context
{
    public class TodoContext : DbContext
    {

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfigurations());
        }

        public DbSet<Work> Works { get; set; }

    }
}
