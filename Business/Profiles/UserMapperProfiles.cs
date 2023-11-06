using AutoMapper;
using Business.Requests.Users;
using Business.Responses.Users;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserMapperProfiles:Profile
    {
        public UserMapperProfiles()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, ListUserResponse>();
        }
    }
}
