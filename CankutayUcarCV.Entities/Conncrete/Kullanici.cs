using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("Kullanici")]
	public class Kullanici : IBase
    {
        public int id { get; set; }
        public string AD { get; set; }
        public string SOYISIM { get; set; }
        public string ADRES { get; set; }
        public string EPOSTA { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
        public string FOTOGRAF_URL { get; set; }
        public string TELEFON_NUMARASI { get; set; }
        public string ACIKLAMA { get; set; }
        public DateTime DOGUM_TARIHI { get; set; }
    }
}
