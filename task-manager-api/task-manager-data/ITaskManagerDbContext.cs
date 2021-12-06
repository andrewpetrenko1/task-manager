using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_data.Models;

namespace task_manager_data
{
    public interface ITaskManagerDbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        int SaveChanges();
    }
}
