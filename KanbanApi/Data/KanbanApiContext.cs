#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KanbanApi.Models;

namespace KanbanApi.Data
{
    public class KanbanApiContext : DbContext

    {
        public KanbanApiContext (DbContextOptions<KanbanApiContext> options)
            : base(options)
        {
        }

        public DbSet<KanbanApi.Models.User> User { get; set; }

        public DbSet<KanbanApi.Models.Project> Project { get; set; }

        public DbSet<KanbanApi.Models.Column> Column { get; set; }

        public DbSet<KanbanApi.Models.Issue> Issue { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User").HasMany(x=>x.Projects).WithOne(x=>x.User).HasForeignKey(x=>x.UserId);
            modelBuilder.Entity<Project>().ToTable("Project").HasMany(x => x.Columns).WithOne(x => x.Project).HasForeignKey(x => x.ProjectId);
            modelBuilder.Entity<Column>().ToTable("Column").HasMany(x => x.Issues).WithOne(x => x.Column).HasForeignKey(x => x.ColumnId);
        }

    }
   

}
