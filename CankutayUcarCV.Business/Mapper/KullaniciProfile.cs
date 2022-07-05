using AutoMapper;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using CankutayUcarCV.Entities.Conncrete;

namespace CankutayUcarCV.Business.Mapper
{
    public class KullaniciProfile : Profile
    {
        public KullaniciProfile()
        {
            CreateMap<Kullanici, KullaniciListDto>().ReverseMap();
        }
    }
}
