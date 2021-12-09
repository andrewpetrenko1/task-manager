using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_business.ViewModels;

namespace task_manager_business.Services
{
    public interface IProjectService
    {
        IEnumerable<ProjectView> GetProjects();
        int AddProject(ProjectView project);
        ProjectView GetProject(int id);
    }
}
