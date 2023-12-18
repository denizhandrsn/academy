using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Modules;
using Business.Responses.Courses;
using Business.Responses.Instructors;
using Business.Responses.Modules;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ModuleManager : IModuleService
    {
        IModuleDal _moduleDal;
        IMapper _mapper;
        ICourseService _courseService;

        public ModuleManager(IModuleDal moduleDal, IMapper mapper, ICourseService courseService)
        {
            _moduleDal = moduleDal;
            _mapper = mapper;
            _courseService = courseService;
        }

        public IResult Add(CreateModuleRequest request)
        {
            var module = _mapper.Map<Module>(request);
            _moduleDal.Add(module);
            return new SuccessDataResult<Module>(module,Messages.Added);
        }

        public IDataResult<List<ListModuleResponse>> GetAll()
        {
            List<Module> modules = _moduleDal.GetAll(include: b => b.Include(b => b.Course).Include(b => b.Course.CourseDetail)
            .Include(b => b.Course.CourseDetail.Category).Include(b=> b.Course.CourseDetail.Instructor).Include(b => b.Course.CourseDetail.Status)
            );
            List<ListModuleResponse> responses = _mapper.Map<List<ListModuleResponse>>(modules);
            
            return new SuccessDataResult<List<ListModuleResponse>>(responses, Messages.Listed);
        }
    }
}
