using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_data.Models;
using task_manager_data.Repostories.Interfaces;

namespace task_manager_data.Repostories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ITaskManagerDbContext _context;
        public ProjectRepository(ITaskManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> GetProjects() => _context.Projects.ToList();

        public Project GetProject(int id) => _context.Projects.FirstOrDefault(p => p.Id == id);

        public int AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project.Id;
        }

        public Project UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
            return project;
        }

        public bool DeleteProject(int id)
        {
            _context.Projects.Remove(_context.Projects.Find(id));
            if (_context.SaveChanges() > 0)
                return true;

            return false;
        }
    }
}
