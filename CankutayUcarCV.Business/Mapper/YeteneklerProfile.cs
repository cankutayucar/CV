using AutoMapper;
using CankutayUcarCV.DTOs.Concrete.YeteneklerDtos;
using CankutayUcarCV.Entities.Conncrete;

namespace CankutayUcarCV.Business.Mapper
{
    public class YeteneklerProfile : Profile
    {
        public YeteneklerProfile()
        {
            CreateMap<Yetenekler, YeteneklerEkleDto>().ReverseMap();
            CreateMap<Yetenekler, YeteneklerGuncelleDto>().ReverseMap();
            CreateMap<Yetenekler, YeteneklerListDto>().ReverseMap();
        }
    }
}
