using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Appoinments.Dto
{
    public class AppoinmentMapProfile : Profile
    {
        public AppoinmentMapProfile()
        {
            CreateMap<AppoinmentDto, Appoinment>();
            CreateMap<Appoinment, AppoinmentDto>();
        }
    }
}