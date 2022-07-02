using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.KullaniciDtos
{
    public class KullaniciGuncelleDto : IBaseDto
    {
        public int id { get; set; }
        public string AD { get; set; }
        public string SOYISIM { get; set; }
        public string ADRES { get; set; }
        public string EPOSTA { get; set; }
        public string FOTOGRAF_URL { get; set; }
        public string TELEFON_NUMARASI { get; set; }
        public string ACIKLAMA { get; set; }
        public string KULLANICI_ADI { get; set; }
        public DateTime DOGUM_TARIHI { get; set; }
    }
}
