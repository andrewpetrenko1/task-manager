using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_data.Models;

namespace task_manager_data.Repostories.Interfaces
{
    public interface IProjectRepository
    {
        public IEnumerable<Project> GetProjects();
        public Project GetProject(int id);
        int AddProject(Project project);
        public Project UpdateProject(Project project);
        public bool DeleteProject(int id);
    }
}
