using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_business.ViewModels;
using task_manager_data.Models;

namespace task_manager_business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectView>().ReverseMap();
        }
    }
}
