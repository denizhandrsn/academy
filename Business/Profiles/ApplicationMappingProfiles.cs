using AutoMapper;
using Business.Requests.Applications;
using Business.Responses.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ApplicationMappingProfiles:Profile
    {
        public ApplicationMappingProfiles()
        {
            CreateMap<CreateApplicationRequest, Application>();
            CreateMap<DeleteApplicationRequest, Application>();
            CreateMap<UpdateApplicationRequest, Application>();
            CreateMap<Application, ListApplicationResponse>();
        }
    }
}
