using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_manager_business.Services;
using task_manager_business.ViewModels;

namespace task_manager_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjectService _service;
        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetProject(id));
        }

        [HttpPost]
        public IActionResult AddProject(ProjectView project)
        {
            if (!ModelState.IsValid)
                return BadRequest(project);

            return Ok(_service.AddProject(project));
        }
    }
}
