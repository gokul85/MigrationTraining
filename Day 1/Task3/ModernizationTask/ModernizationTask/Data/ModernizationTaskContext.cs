using Microsoft.EntityFrameworkCore;
using ModernizationTask.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ModernizationTask.Data
{
    public class ModernizationTaskContext : DbContext
    {
        public ModernizationTaskContext(DbContextOptions<ModernizationTaskContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<LoginBean> LoginBeans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
