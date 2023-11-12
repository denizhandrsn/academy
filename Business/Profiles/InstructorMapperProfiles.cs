using AutoMapper;
using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class InstructorMapperProfiles:Profile
    {
        public InstructorMapperProfiles()
        {
            CreateMap<Instructor, ListInstructorResponses>();
            CreateMap<CreateInstructorRequest, Instructor>();
        }
    }
}
