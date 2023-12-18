using AutoMapper;
using Business.Requests.Categories;
using Business.Responses.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CategoryMappingProfiles:Profile
    {
        public CategoryMappingProfiles()
        {
            CreateMap<Category, ListCategoryResponse>().ReverseMap();
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
        }
    }
}
