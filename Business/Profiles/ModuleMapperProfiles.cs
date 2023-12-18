using AutoMapper;
using Business.Requests.Modules;
using Business.Responses.Courses;
using Business.Responses.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ModuleMapperProfiles:Profile
    {
        public ModuleMapperProfiles()
        {
            CreateMap<CreateModuleRequest, Module>().ReverseMap();
            CreateMap<Module, ListModuleResponse>().ReverseMap();
            CreateMap<List<ListCourseResponse>, ListModuleResponse>();
        }
    }
}
