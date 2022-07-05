using Microsoft.AspNetCore.Mvc.Filters;

namespace CankutayUcarCV.Web.Models
{
    public class KullaniciGuncelleViewModel
    {
        public int id { get; set; }
        public string AD { get; set; }
        public string SOYISIM { get; set; }
        public string ADRES { get; set; }
        public string EPOSTA { get; set; }
        public string FOTOGRAF_URL { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string TELEFON_NUMARASI { get; set; }
        public string ACIKLAMA { get; set; }
        public IFormFile Picture { get; set; }
        public DateTime DOGUM_TARIHI { get; set; }
    }
}
