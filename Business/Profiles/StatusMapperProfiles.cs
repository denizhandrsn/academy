using AutoMapper;
using Business.Requests.Modules;
using Business.Requests.Statuses;
using Business.Responses.Statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class StatusMapperProfiles:Profile
    {
        public StatusMapperProfiles()
        {
            CreateMap<CreateStatusRequest, Status>();
            CreateMap<DeleteStatusRequest, Status>();
            CreateMap<UpdateStatusRequest, Status>();
            CreateMap<Status, ListStatusResponse>();
        }
    }
}
