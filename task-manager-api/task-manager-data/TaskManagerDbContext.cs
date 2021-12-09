using Microsoft.EntityFrameworkCore;
using System;
using task_manager_data.Models;

namespace task_manager_data
{
    public class TaskManagerDbContext : DbContext, ITaskManagerDbContext
    {
        public TaskManagerDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var project = modelBuilder.Entity<Project>();
            project
                .Property(p => p.Name)
                .HasMaxLength(500)
                .IsRequired();
            project
                .Property(p => p.Description)
                .HasMaxLength(1000);

            var column = modelBuilder.Entity<Column>();
            column
                .Property(c => c.Name)
                .HasMaxLength(255)
                .IsRequired();
            column
                .HasIndex(c => c.Name)
                .IsUnique();
            column
                .HasOne(c => c.Project)
                .WithMany(p => p.Columns)
                .HasForeignKey(c => c.ProjectId);

            var task = modelBuilder.Entity<TaskModel>();
            task
                .Property(t => t.Name)
                .HasMaxLength(500)
                .IsRequired();
            task
                .Property(t => t.Description)
                .HasMaxLength(5000);
            task
                .HasOne(t => t.Column)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.ColumnId);
            task
                .Property(t => t.Priority)
                .HasDefaultValue(0);

            var comment = modelBuilder.Entity<Comment>();
            comment
                .Property(c => c.Text)
                .HasMaxLength(5000)
                .IsRequired();
            comment
                .Property(c => c.CreationDate)
                .HasDefaultValueSql("getutcdate()");
            comment
                .HasOne(c => c.Task)
                .WithMany(task => task.Comments)
                .HasForeignKey(c => c.TaskId);

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
