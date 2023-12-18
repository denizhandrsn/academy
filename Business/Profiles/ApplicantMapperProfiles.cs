using AutoMapper;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ApplicantMapperProfiles:Profile
    {
        public ApplicantMapperProfiles()
        {
            CreateMap<Applicant,ListApplicantResponse>();
            CreateMap<CreateApplicantRequest, Applicant>();
            CreateMap<DeleteApplicantRequest, Applicant>();
            CreateMap<UpdateApplicantRequest, Applicant>();
        }
    }
}
