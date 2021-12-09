using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_business.ViewModels;
using task_manager_data.Models;
using task_manager_data.Repostories.Interfaces;

namespace task_manager_business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;
        public ProjectService(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ProjectView> GetProjects()
            => _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectView>>(_repository.GetProjects());

        public int AddProject(ProjectView project)
            => _repository.AddProject(_mapper.Map<ProjectView, Project>(project));

        public ProjectView GetProject(int id)
            => _mapper.Map<Project, ProjectView>(_repository.GetProject(id));
    }
}
