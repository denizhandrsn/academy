using AutoMapper;
using Business.Requests.Users;
using Business.Responses.Users;

namespace Business.Profiles
{
    public class UserMapperProfiles:Profile
    {
        public UserMapperProfiles()
        {
            CreateMap<CreateUserRequest, User>().ReverseMap();
            CreateMap<User, ListUserResponse>();
            CreateMap<DeleteUserRequest, User>().ReverseMap();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
        }
    }
}
