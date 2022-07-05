using AutoMapper;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using CankutayUcarCV.Entities.Conncrete;
using CankutayUcarCV.Web.Models;

namespace CankutayUcarCV.Web.UIMapper
{
    public class KullaniciDtoProfile : Profile
    {
        public KullaniciDtoProfile()
        {
            CreateMap<Kullanici, KullaniciGuncelleViewModel>().ReverseMap();
        }
    }
}
