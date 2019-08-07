using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_core_entityToDoList_01.Models;

namespace MVC_core_entityToDoList_01.Models
{
    public class TaskDBContextContext : DbContext
    {
        public TaskDBContextContext (DbContextOptions<TaskDBContextContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_core_entityToDoList_01.Models.Task> Task { get; set; }

        public DbSet<MVC_core_entityToDoList_01.Models.Category> Category { get; set; }
        //fluent API

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //relationships
            //category name is required
            builder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(15);

            builder.Entity<Category>().HasMany(c => c.Tasks).WithOne(task => task.category);

            //one category can have many tasks

            builder.Entity<Task>().HasOne(task => task.category).WithMany(Category => Category.Tasks);
        }
    }
}
