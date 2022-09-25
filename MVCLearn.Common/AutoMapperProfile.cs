using AutoMapper;
using MVCLearn.DAL;
using MVCLearn.MAL;

namespace MVCLearn.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeModel, Employee>().ReverseMap();
        }
    }
}