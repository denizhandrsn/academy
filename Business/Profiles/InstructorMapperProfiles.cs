using AutoMapper;
using Business.Requests.Instructors;
using Business.Responses.Instructors;

namespace Business.Profiles
{
    public class InstructorMapperProfiles:Profile
    {
        public InstructorMapperProfiles()
        {
            CreateMap<Instructor, ListInstructorResponse>();
            CreateMap<CreateInstructorRequest, Instructor>();
            CreateMap<UpdateInstructorRequest, Instructor>();
            CreateMap<DeleteInstructorRequest, Instructor>();

        }
    }
}
